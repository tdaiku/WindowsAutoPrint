using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsAutoPrint
{
    [Serializable]
    public class Config
    {
        /// <summary>
        /// XML設定ファイル
        /// </summary>
        private const string FILE_NAME = @"homeAppManager.xml";

        public static Config init;

        ///設定
        public string Key { get; set; }
        public string Value { get; set; }
        public string SvPath { get; set; }
        public string Api { get; set; }
        public string ApiPict { get; set; }
        public string PrinterNm { get; set; }
        public bool AutoUpdate { get; set; }
        public bool AutoPrint { get; set; }

        //インナーデータ
        public int lastId { get; set; }

        #region XML保存@外のクラス
        public static bool SerializeToXmlConfig()
        {
            try
            {
                //XmlSerializerオブジェクトを作成
                using (System.IO.TextWriter writer = new System.IO.StreamWriter(FILE_NAME, false, Encoding.UTF8))
                {
                    System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(init.GetType());
                    serializer.Serialize(writer, init);
                }
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        #endregion

    }
}
