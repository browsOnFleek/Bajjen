using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;




using System;

namespace data
{
    public class Ressfetch
    {

        public XmlDocument fetchRss(string url)
        {

            var xml = "";
            using (var client = new System.Net.WebClient())
            {
                client.Encoding = Encoding.UTF8;
                xml = client.DownloadString(url);
            }

            //Skapa en objektrepresentation.
            var dom = new System.Xml.XmlDocument();
            dom.LoadXml(xml);

            return dom;


        }

        public XmlDocument fetchBase()
        {

            var dom = new XmlDocument();
            dom.LoadXml(@"C:\Users\jonas\documents\visual studio 2015\Projects\Bajjen\data\XMLBase.xml");
            return dom;



        }
    }
}
