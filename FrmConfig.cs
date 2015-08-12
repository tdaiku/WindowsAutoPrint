using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsAutoPrint
{
    public partial class FrmConfig : Form
    {
        public FrmConfig()
        {
            InitializeComponent();
        }

        #region XML読込
        private void DesirializeFromXml()
        {
            this.txt_Key.Text = Config.init.Key;

            this.txt_Value.Text = Config.init.Value;
            this.txt_SvPath.Text = Config.init.SvPath;

            this.txt_Api.Text = Config.init.Api;
            this.txt_ApiPict.Text = Config.init.ApiPict;

            this.txt_PrinterNm.Text = Config.init.PrinterNm;
            this.chk_AutoUpdate.Checked = Config.init.AutoUpdate;
            this.chk_AutoPrint.Checked = Config.init.AutoPrint;

        }
        #endregion

        #region XML保存
        private bool SerializeToXml()
        {
            try
            {
                Config.init.Key = this.txt_Key.Text;
                Config.init.Value = this.txt_Value.Text;
                Config.init.SvPath = this.txt_SvPath.Text;
                Config.init.Api = this.txt_Api.Text;
                Config.init.ApiPict = this.txt_ApiPict.Text;
                Config.init.PrinterNm = this.txt_PrinterNm.Text;
                Config.init.AutoUpdate = this.chk_AutoUpdate.Checked;
                Config.init.AutoPrint = this.chk_AutoPrint.Checked;


                Config.SerializeToXmlConfig();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }
        #endregion

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SerializeToXml();
            this.Close();
        }

        private void FrmConfig_Load(object sender, EventArgs e)
        {
            DesirializeFromXml();
        }
    }
}
