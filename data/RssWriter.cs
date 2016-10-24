using System.Xml;
using System;

namespace data
{
    public static class RssWriter
    {

        private static XmlDocument doc = Ressfetch.fetchBase();
        private static string title = "";
        private static XmlElement feedElement;


        public static void writeExisting(XmlDocument dom, string rssName)
        {

            feed
            feedElement = doc.CreateElement(rssName);
            feedElement.SetAttribute("feed", rssName);
            
            doc.DocumentElement.AppendChild(feedElement);



            foreach (XmlNode channelItem
               in dom.DocumentElement.SelectNodes("channel/item"))
            {

                title = channelItem.SelectSingleNode("title").InnerText;



                addElements(rssName);

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
            feedElement.AppendChild(podElement);
            doc.Save(@"C:\Users\jonas\documents\visual studio 2015\Projects\Bajjen\data\XMLBase.xml");
        }
    }
}
