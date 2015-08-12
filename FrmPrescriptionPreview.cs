using Codeplex.Data;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsAutoPrint
{
    public partial class FrmPrescriptionPreview : Form
    {
        private bool isLandscape = false;
        private bool isColor = false;

        private string id = "";
        private string patientNm = "";
        private string tel = "";
        private string visitTiming = "";
        private int prescriptionCnt = 0;
        private int printEndCnt = 0;
        private Bitmap prescriptionImage;
        WebClient wc = new WebClient();

        public FrmPrescriptionPreview()
        {
            InitializeComponent();
        }

        public FrmPrescriptionPreview(bool isLandscape, bool isColor):this()
        {
            this.isLandscape = isLandscape;
            this.isColor = isColor;
        }


        public bool setCompositionInfo(dynamic composition){
            try
            {
                this.id = composition.id.ToString("#0");
                this.patientNm = composition.m_patient_name;
                this.tel = composition.tel;
                this.visitTiming = composition.visit_timing;

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show( "WEBの管理画面から状態を確認してください。" + "\n" + ex.Message,
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
        }


        private void getPrescriptions()
        {
            Encoding enc = Encoding.UTF8;
            WebClient wc = new WebClient();
            wc.Encoding = System.Text.Encoding.UTF8;

            //クエリパラメータ
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("id", id);
            wc.QueryString = nvc;

            wc.DownloadStringCompleted += (s, result) =>
            {
                if (result.Error == null)
                {
                    var res = result.Result;
                    var json = DynamicJson.Parse(res);

                    object[] jsonArray = (object[])json;

                    initializePrinterSettings();
                    prescriptionCnt = jsonArray.Length;
                    printEndCnt = 0;

                    foreach (var item in jsonArray)
                    {
                        dynamic dynamicItem = (dynamic)item;
                        if (dynamicItem.IsDefined("prescription"))
                        {
                            //画像のロードと印刷指示
                            string url = dynamicItem.prescription.url;

                            Stream stream = wc.OpenRead(Config.init.SvPath + url);
                            Bitmap bitmap = new Bitmap(stream);
                            stream.Close();
                            prescriptionImage = bitmap;

                            printDocument1.Print();
                        }
                    }
                }
                else
                {
                    Console.WriteLine(result);
                }
            };
            wc.DownloadStringAsync(new Uri(Config.init.SvPath + Config.init.ApiPict));
        }

        protected void initializePrinterSettings()
        {
            //プリンタ名の設定
            //this.printDocument1.DefaultPageSettings.PrinterSettings.PrinterName = printerName;
            this.printDocument1.PrinterSettings.PrinterName = Config.init.PrinterNm;
            if (this.printDocument1.DefaultPageSettings.PrinterSettings.IsValid == false)
            {
                //プリンター名がおかしい場合の処理．
                throw new Exception("specified printer name is invalid");
            }
            int paperIndex = 0;
            foreach (PaperSize ps in printDocument1.PrinterSettings.PaperSizes)
            {
                Console.WriteLine(ps.PaperName);
                if (ps.PaperName.Contains("A4"))//用紙のサイズ指定
                {
                    break;
                }
                paperIndex++;
            }
            printDocument1.DefaultPageSettings.PaperSize =
            printDocument1.PrinterSettings.PaperSizes[paperIndex];
            printDocument1.DefaultPageSettings.Landscape = false; //横向きならtrue
            printDocument1.DefaultPageSettings.Color = false; //カラー印刷ならtrue
        }


        //印刷イベントハンドラ
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //拡大率を指定．
            float zoom = 1;
            float padding = 60;
            if (this.prescriptionImage.Width > e.Graphics.VisibleClipBounds.Width)
            {
                zoom = e.Graphics.VisibleClipBounds.Width /
                    this.prescriptionImage.Width;
            }
            if ((this.prescriptionImage.Height + padding) * zoom >
                    e.Graphics.VisibleClipBounds.Height)
            {
                zoom = e.Graphics.VisibleClipBounds.Height /
                    (this.prescriptionImage.Height + padding);
            }
            e.Graphics.DrawString((printEndCnt+1).ToString("#0") + "/" + prescriptionCnt.ToString("#0") + "　" +
                                    DateTime.Now.ToString("MM月dd日 (dddd) tt hh時mm分ss秒"),
                                  new Font("メイリオ", 18), Brushes.Black, new Point(0, 0));

            e.Graphics.DrawString("ID:" + id + " " + patientNm + " " + this.tel + " " + this.visitTiming,
                new Font("メイリオ", 18), Brushes.Black, new Point(0, 30));

            //EventArgsのGraphicsにデータを書き込むとそれが印刷される．
            e.Graphics.DrawImage(this.prescriptionImage, 0, padding,
                                               e.Graphics.VisibleClipBounds.Width,
                                               e.Graphics.VisibleClipBounds.Height);
                                               //this.prescriptionImage.Width * zoom,
                                               //this.prescriptionImage.Height * zoom);
        }

        private void FrmPrescriptionPreview_Load(object sender, EventArgs e)
        {
            this.getPrescriptions();

        }

        private void printDocument1_EndPrint(object sender, PrintEventArgs e)
        {
            printEndCnt++;
            if (printEndCnt >= prescriptionCnt)
            {
                this.Close();
            }
        }
    }
}
