using System.Text;
using System.Xml;
using System;
using System.IO;
using static System.Net.Mime.MediaTypeNames;


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

            
         


        }

        public static XmlDocument fetchBase()
        {

            string path2 = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

            string path = Directory.GetCurrentDirectory() + @"\XMLBase.xml";
            var dom = new XmlDocument();
            dom.Load(path);
            return dom;



        } 
    }
}
