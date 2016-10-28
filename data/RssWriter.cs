using System.Xml;
using System;

namespace data
{
    public static class RssWriter
    {

        private static XmlDocument doc = Ressfetch.fetchBase();
        private static string title = "";
        private static string enclosure = "";
        private static string status = "0";
        private static XmlElement feedElement;


        public static void writeExisting(XmlDocument dom, string rssName, string chosenCategory, string interval)
        {
            bool _exists = false;


            feedElement = doc.CreateElement("feed");
            feedElement.SetAttribute("feed", rssName);
            feedElement.SetAttribute("interval", interval);

            foreach (XmlNode getCategory in doc.DocumentElement.SelectNodes("category"))
            {
                string xmlCategory = getCategory.Attributes["cat"].Value;


                if (chosenCategory.Equals(xmlCategory))
                {
                    _exists = true;

                    getCategory.AppendChild(feedElement);
                }

            }

            if (_exists == false)
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

                enclosure = channelItem.SelectSingleNode("enclosure/@url").InnerText;


                addElements(rssName);


            }

        }






        private static void addElements(string rssName)
        {

            XmlElement podElement = doc.CreateElement("item");
            XmlElement titleElement = doc.CreateElement("title");
            XmlElement podCast = doc.CreateElement("pod");
            XmlElement podurl = doc.CreateElement("enclosure");
            XmlElement podStatus = doc.CreateElement("status");

            titleElement.InnerText = title;
            podurl.InnerText = enclosure;
            podCast.InnerText = rssName;
            podStatus.InnerText = status;



            podElement.AppendChild(titleElement);
            podElement.AppendChild(podurl);
            podElement.AppendChild(podCast);
            podElement.AppendChild(podStatus);
            feedElement.AppendChild(podElement);
            doc.Save(@"C:\Users\Tobias\Source\Repos\Bajjen\data\XMLBase.xml");
        }

        public static void changeStatus(string buttonText)
        {
            doc = Ressfetch.fetchBase();


            foreach (XmlNode xmlTitle in doc.DocumentElement.SelectNodes("category/feed/item"))
            {
                string title = xmlTitle.SelectSingleNode("title").InnerText;
                Console.WriteLine("bajs");

                if (title.Equals(buttonText))
                {
                    xmlTitle.SelectSingleNode("title").InnerText = "1";
                    Console.WriteLine("joakim");
                }
            }
        }
    }
}
