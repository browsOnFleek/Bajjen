using System.Xml;
using System;

namespace data
{
    public static class RssWriter
    {

        private static XmlDocument doc = Ressfetch.fetchBase();
        private static string title = "";
        private static string enclosure = "";
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

            titleElement.InnerText = title;
            podurl.InnerText = enclosure;
            podCast.InnerText = rssName;



            podElement.AppendChild(titleElement);
            podElement.AppendChild(podurl);
            podElement.AppendChild(podCast);
            feedElement.AppendChild(podElement);
            doc.Save(@"C:\Users\Tobias\Source\Repos\Bajjen\data\XMLBase.xml");
        }
    }
}
