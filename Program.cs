using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsAutoPrint
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            /// <summary>
            /// XML設定ファイル
            /// </summary>
            const string FILE_NAME = @"homeAppManager.xml";

            try
            {
                using (System.IO.TextReader reader = new System.IO.StreamReader(FILE_NAME, Encoding.UTF8, false))
                {
                    System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Config));
                    Config.init = (Config)serializer.Deserialize(reader);
                }
            }
            catch (System.IO.FileNotFoundException ex)
            {
                //XmlSerializerオブジェクトを作成
                using (System.IO.TextWriter writer = new System.IO.StreamWriter(FILE_NAME, false, Encoding.UTF8))
                {
                    System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(Config.init.GetType());
                    serializer.Serialize(writer, Config.init);
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_Main());

        }
    }
}
