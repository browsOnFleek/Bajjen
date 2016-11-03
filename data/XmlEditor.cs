using System;
using System.Collections.Generic;
using System.IO;
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
        private static string enclosure = "";
        private static string status = "0";
        private static string description = "";


        public static void writeExisting(XmlDocument dom, string rssName)
        {

            feedNode = doc.SelectSingleNode("//feed[@feed='" +rssName+ "']");

           string helloy = feedNode.Attributes["feed"].Value;  


            foreach (XmlNode channelItem
               in dom.DocumentElement.SelectNodes("channel/item"))
            {

               

                title = channelItem.SelectSingleNode("title").InnerText;

                enclosure = channelItem.SelectSingleNode("enclosure/@url").InnerText;

                description = channelItem.SelectSingleNode("description").InnerText;
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
            XmlElement podurl = doc.CreateElement("enclosure");
            XmlElement podStatus = doc.CreateElement("status");
            XmlElement podDescription = doc.CreateElement("description");

            titleElement.InnerText = title;
            podCast.InnerText = rssName;
            string kokkos = feedNode.Attributes["feed"].Value;
            podurl.InnerText = enclosure;
            podStatus.InnerText = status;
            podDescription.InnerText = description;



            Console.WriteLine("korv");
            podElement.AppendChild(podurl);
            podElement.AppendChild(titleElement);
            podElement.AppendChild(podCast);
            podElement.AppendChild(podStatus);
            podElement.AppendChild(podDescription);
            feedNode.AppendChild(podElement);
            string path = Directory.GetCurrentDirectory() + @"\XMLBase.xml";
            doc.Save(path);
        }







       
        



      

    }
}
