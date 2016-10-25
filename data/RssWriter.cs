using System.Xml;
using System;

namespace data
{
    public static class RssWriter
    {

        private static XmlDocument doc = Ressfetch.fetchBase();
        private static string title = "";
        private static XmlElement feedElement;


        public static void writeExisting(XmlDocument dom, string rssName, string chosenCategory)
        {
            bool _exists = false;
            Console.WriteLine("elo");

            feedElement = doc.CreateElement("feed");
            feedElement.SetAttribute("feed", rssName);

            foreach (XmlNode getCategory in doc.DocumentElement.SelectNodes("category"))
            {
                string xmlCategory = getCategory.Attributes["cat"].Value;

                Console.WriteLine("foreach");
                if (chosenCategory.Equals(xmlCategory))
                {
                    _exists = true;
                    Console.WriteLine("if");
                    getCategory.AppendChild(feedElement);
                }
                
            }

            if(_exists == false)
            {
                 XmlElement category = doc.CreateElement("category");
                 category.SetAttribute("cat", chosenCategory);
            category.AppendChild(feedElement);
            doc.DocumentElement.AppendChild(category);
            }


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
            doc.Save(@"C:\Users\Tobias\Source\Repos\Bajjen\data\XMLBase.xml");
        }
    }
}
