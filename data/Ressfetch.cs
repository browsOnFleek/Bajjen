using System.Text;
using System.Xml;

namespace data
{
    internal class emptyClass
    {
        internal string emptyString = "";
    }
    public class Ressfetch
    {

        public static XmlDocument fetchRss(string url)
        {
            emptyClass tom = new emptyClass();
            var xml = tom.emptyString;
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

        public static XmlDocument fetchBase()
        {

            var dom = new XmlDocument();
            dom.Load(@"C:\Users\jonas\documents\visual studio 2015\Projects\Bajjen\data\XMLBase.xml");
            return dom;



        } 
    }
}
