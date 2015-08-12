using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Collections.Specialized;
using System.Net;
using Newtonsoft.Json;
using Codeplex.Data;

namespace WindowsAutoPrint
{
    public partial class frm_Main : Form
    {
        private int preCnt = 0;
        private bool fourceClose = false;
        private bool isCheckNow = false;
        FrmPrescriptionPreview frmPrescriptionPreview = new FrmPrescriptionPreview();
        FrmConfig frmConfig = new FrmConfig();

        public frm_Main()
        {

            InitializeComponent();
            //ディスプレイの高さ
            int displayHeight = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height;
            //ディスプレイの幅
            int displayWidth = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width;

            //this.Location = new Point(displayHeight - this.Size.Height, displayWidth - this.Size.Width);
            this.Location = new Point(displayWidth - this.Size.Width, displayHeight - this.Size.Height);

        }

        /// <summary>
        /// フォームロードイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_Main_Load(object sender, EventArgs e)
        {
            //常駐アプリなのでタスクバーに表示しない
            this.ShowInTaskbar = false;
            //最大化ボタン無効
            this.MaximizeBox = false;

            loadConfig();

            if (chk_AutoUpdate.Checked)
            {
                btn_Update_Click(sender, e);
            }

            /*
            this.SetBounds(this.Left, this.Top, 301, 301,
                    BoundsSpecified.Size);
            System.Drawing.Drawing2D.GraphicsPath path =
                new System.Drawing.Drawing2D.GraphicsPath();
            //丸を描く
            path.AddEllipse(new Rectangle(0, 0, 300, 300));
            this.Region = new Region(path);
             * */
        }

        /// <summary>
        /// 更新ボタンクリックイベント
        /// 設定のAPIよりデータ一覧を取得する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Update_Click(object sender, EventArgs e)
        {
            
            //設定ファイルが存在しない場合は処理しない
            if (Config.init.SvPath == "") return;

            Encoding enc = Encoding.UTF8;
            WebClient wc = new WebClient();
            wc.Encoding = System.Text.Encoding.UTF8;

            //クエリパラメータ
            NameValueCollection nvc = new NameValueCollection();
            if (txt_Value.Text != "")
            {
                nvc.Add(Config.init.Key, txt_Value.Text.ToString());
            }
            wc.QueryString = nvc;

            wc.DownloadStringCompleted += (s, result) =>
            {
                if (result.Error == null)
                {
                    this.WindowState = FormWindowState.Normal;
                    var res = result.Result;
                    var json = DynamicJson.Parse(res);

                    object[] jsonArray = (object[])json;

                    txt_Result.Text = jsonArray.Length.ToString("#0") + "件の未受付データがあります\n" + txt_Result.Text;
                    if (preCnt < jsonArray.Length)
                    {
                        preCnt = jsonArray.Length;
                    }



                    foreach (var item in jsonArray)
                    {
                        dynamic dynamicItem = (dynamic)item;
                        if (dynamicItem.IsDefined("id"))
                        {
                            if (Config.init.lastId < dynamicItem.id)
                            {
                                //新規処方せんの番号を設定ファイルに保存する
                                Config.init.lastId = (int)dynamicItem.id;
                                Config.SerializeToXmlConfig();

                                //印刷確認後に処方せん印刷処理
                                if (chk_AutoPrint.Checked)
                                {
                                    if (frmPrescriptionPreview.setCompositionInfo(dynamicItem))
                                    {
                                        frmPrescriptionPreview.ShowDialog();
                                    }
                                    else { return; }
                                }else
                                {
                                    DialogResult dialogResult = MessageBox.Show("処方せんID：" + dynamicItem.id.ToString("#0") + " を印刷しますか？" + "\n" +
                                        "※次回からの印刷はWEBから行ってください。",
                                            "確認",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question,
                                            MessageBoxDefaultButton.Button2);

                                    if (dialogResult == DialogResult.Yes)
                                    {
                                        if (frmPrescriptionPreview.setCompositionInfo(dynamicItem))
                                        {
                                            frmPrescriptionPreview.ShowDialog();
                                        }
                                        else { return; }
                                    }
                                }
                            }
                        }
                        //txt_Result.Text = +json[i].id.ToString("#0") + "\r\n";
                        //txt_Result.Text += ((dynamic)item).id.ToString("#0");
                    }
                    this.isCheckNow = false;
                }
                else
                {
                    // エラー処理
                    txt_Result.Text ="エラーが発生しました\n" + txt_Result.Text;
                    Console.WriteLine(result);
                    txt_Result.Text = result.ToString();
                    this.isCheckNow = false;
                }
            };
            this.isCheckNow = true;
            //txt_Result.Text =  "データチェック中・・・\n" + txt_Result.Text;
            wc.DownloadStringAsync(new Uri(Config.init.SvPath + Config.init.Api));
        }



        /// <summary>
        /// デシリアライズしたConfigオブジェクトの状態をフォームに反映する
        /// TODO 設定項目を追加した場合
        /// </summary>
        private void loadConfig()
        {
            chk_AutoUpdate.Checked = Config.init.AutoUpdate;
            chk_AutoPrint.Checked = Config.init.AutoPrint;
            txt_Key.Text = Config.init.Key;
            txt_Value.Text = Config.init.Value;
        }

        /// <summary>
        /// フォーム終了イベント
        /// タスクトレイの右クリック削除以外では最小化して終了しない
        /// ※常駐アプリのため
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (fourceClose)
            {

            }
            else
            {
                e.Cancel = true;
            }
            this.WindowState = FormWindowState.Minimized;
        }


        /// <summary>
        /// 自動更新チェックボックスStateChangeイベント
        /// タイマーの有効・無効を切り替える
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_AutoUpdate_CheckStateChanged(object sender, EventArgs e)
        {
            if (chk_AutoUpdate.Checked)
            {
                timmer_Update.Enabled = true;
            }
            else
            {
                timmer_Update.Enabled = false;
            }
        }

        /// <summary>
        /// タイマーTickイベント
        /// 更新チェック中じゃなければ更新チェックする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timmer_Update_Tick(object sender, EventArgs e)
        {
            if (isCheckNow) return;

            btn_Update_Click(sender, e);
        }


        /// <summary>
        /// PrintPageイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pd_PrintPage(object sender,
            System.Drawing.Printing.PrintPageEventArgs e)
        {
            //画像を読み込む
            Image img = Image.FromFile("test.bmp");
            //画像を描画する
            e.Graphics.DrawImage(img, e.MarginBounds);
            //次のページがないことを通知する
            e.HasMorePages = false;
            //後始末をする
            img.Dispose();
        }


        /// <summary>
        /// 印刷ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Print_Click(object sender, EventArgs e)
        {
            frmPrescriptionPreview.ShowDialog();
        }

        /// <summary>
        /// 設定ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Config_Click(object sender, EventArgs e)
        {
            frmConfig.ShowDialog();
            loadConfig();
        }

        #region "タスクバー関連イベント"
        /// <summary>
        /// タスクバーダブルクリックイベント
        /// メインウィンドウを開く
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void noty_Task_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        /// <summary>
        /// タスクバー右クリック　設定ボタン
        /// 設定ウィンドウを開く
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfig.ShowDialog();
            loadConfig();
        }


        /// <summary>
        /// タスクバー右クリック　開くボタン
        /// メインウィンドウを開く
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 開くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }


        /// <summary>
        /// タスクバー右クリック　終了ボタン
        /// アプリを終了する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noty_Task.Visible = false;
            this.fourceClose = true;
            Application.Exit();
        }
        #endregion

    }
}
