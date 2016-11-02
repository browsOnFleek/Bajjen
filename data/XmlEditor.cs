using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace data
{
    public static class XmlEditor
    {



        private static bool exist = false;
   
     
        private static XmlDocument doc = Ressfetch.fetchBase();
        private static string title = "";
        public static XmlNode feedNode;


        public static void writeExisting(XmlDocument dom, string rssName)
        {

            feedNode = doc.SelectSingleNode("//feed[@feed='" +rssName+ "']");

           string helloy = feedNode.Attributes["feed"].Value;  


            foreach (XmlNode channelItem
               in dom.DocumentElement.SelectNodes("channel/item"))
            {

               

                title = channelItem.SelectSingleNode("title").InnerText;

                if (findDoubles.doublePods(title) == false) {

                    addElements(rssName);


                }
                
               
            }
        }


        public static void addElements(string rssName)
        {

            XmlElement podElement = doc.CreateElement("item");
            XmlElement titleElement = doc.CreateElement("title");
            XmlElement podCast = doc.CreateElement("pod");
            titleElement.InnerText = title;
            podCast.InnerText = rssName;
            string kokkos = feedNode.Attributes["feed"].Value;

            Console.WriteLine("korv");
            podElement.AppendChild(titleElement);
            podElement.AppendChild(podCast);
            feedNode.AppendChild(podElement);
            doc.Save(@"C:\Users\jonas\documents\visual studio 2015\Projects\Bajjen\data\XMLBase.xml");
        }







       
        



      

    }
}
