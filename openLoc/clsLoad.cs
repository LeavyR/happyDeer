using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace openLoc
{
    public  class clsLoad
    {
        public static clsLoad cl = new clsLoad();
        /// <summary>
        /// 读取实时数据库连接数据
        /// </summary>
        /// <returns></returns>
        public Hashtable Deal()
        {
            Hashtable ht = new Hashtable();
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(Application.StartupPath + "//config.xml");
            XmlNodeList SourceList = xmlDocument.SelectNodes("data/loc");
            foreach (XmlNode source in SourceList)
            {
                try
                {
                    string scValue = source.InnerText;
                    string scKey = source.Attributes["name"].Value;
                    ht.Add(scKey, scValue);
                }
                catch
                {
                    continue;
                }
               
               
               
            }
            return ht;
        }
    }
}
