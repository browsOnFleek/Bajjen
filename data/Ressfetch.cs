using System.Text;
using System.Xml;

namespace data
{
    public abstract class Ressfetch
    {

        public static XmlDocument fetchRss(string url)
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

        public static XmlDocument fetchBase()
        {

            var dom = new XmlDocument();
            dom.Load(@"C:\Users\Tobias\Source\Repos\Bajjen\data\XMLBase.xml");
            return dom;



        } 
    }
}
