using System.Text;
using System.Xml;
using System;

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

                try
                {
                    xml = client.DownloadString(url);



                    var dom = new System.Xml.XmlDocument();
                    dom.LoadXml(xml);

                    return dom;
                }

                catch (System.Net.WebException e)
                {
                    Console.WriteLine("error error");
                    var dom = new System.Xml.XmlDocument();
                    dom = null;
                    return dom;
                }

            }

            //Skapa en objektrepresentation.
         


        }

        public static XmlDocument fetchBase()
        {

            var dom = new XmlDocument();
            dom.Load(@"C:\Users\Tobias\Source\Repos\Bajjen\data\XMLBase.xml");
            return dom;



        } 
    }
}
