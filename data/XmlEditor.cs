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
        private static XmlNode feedNode;


        public static void writeExisting(XmlDocument dom, string rssName)
        {

            XmlNode feedNode = doc.SelectSingleNode("//feed[@id='" +rssName+ "']");

            foreach (XmlNode channelItem
               in dom.DocumentElement.SelectNodes("channel/item"))
            {

                exist = false;

                title = channelItem.SelectSingleNode("title").InnerText;

                lookForDubble(rssName);

            }
        }


        private static void addElements(string rssName)
        {

            XmlElement podElement = doc.CreateElement("item");
            XmlElement titleElement = doc.CreateElement("title");
            XmlElement podCast = doc.CreateElement("pod");
            titleElement.InnerText = title;
            podCast.InnerText = rssName;

         

            podElement.AppendChild(titleElement);
            podElement.AppendChild(podCast);
            feedNode.AppendChild(podElement);
            doc.Save(@"C:\Users\Tobias\Source\Repos\Bajjen\data\XMLBase.xml");
        }







        private static void lookForDubble(string rssName)
        {


            foreach (XmlNode item
                      in doc.DocumentElement.SelectNodes("item"))
            {

                string check = item.SelectSingleNode("title").InnerText;

                if (title.Equals(check))
                {
                    exist = true;
                }
            }

            if (exist == false)
            {
                addElements(rssName);
            }
        }



      

    }
}
