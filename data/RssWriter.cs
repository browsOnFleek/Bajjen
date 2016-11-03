using System.Xml;
using System;
using System.IO;

namespace data
{
    public class RssWriter : BaseClass
    {

        private static XmlDocument doc = Ressfetch.fetchBase();
        private static string title = "";
        private static string enclosure = "";
        private static string status = "0";
        private static string description = "";
        private static XmlElement feedElement;


        public static void addFeed(XmlDocument dom, string rssName, string chosenCategory, string interval, string url)
        {

            if (dom == null) { }
            else
            {

                feedElement = doc.CreateElement("feed");
                feedElement.SetAttribute("feed", rssName);
                feedElement.SetAttribute("interval", interval);
                feedElement.SetAttribute("url", url);

                foreach (XmlNode getCategory in doc.DocumentElement.SelectNodes("category"))
                {
                    string xmlCategory = getCategory.Attributes["cat"].Value;


                    if (chosenCategory.Equals(xmlCategory))
                    {


                        getCategory.AppendChild(feedElement);
                    }

                }


                foreach (XmlNode channelItem
                   in dom.DocumentElement.SelectNodes("channel/item"))
                {

                    title = channelItem.SelectSingleNode("title").InnerText;

                    enclosure = channelItem.SelectSingleNode("enclosure/@url").InnerText;

                    description = channelItem.SelectSingleNode("description").InnerText;
                    RssWriter writer = new RssWriter();
                    writer.addElements(rssName);


                }
            }
        }


        public static void appendFeedToCategory(string feedName, string chosenCategory) {

            doc = Ressfetch.fetchBase();

            foreach (XmlNode xmlFeed in doc.DocumentElement.SelectNodes("category/feed"))
            {
                string check = xmlFeed.Attributes["feed"].Value;


                if (check.Equals(feedName)) {

                    foreach (XmlNode getCategory in doc.DocumentElement.SelectNodes("category"))
                    {
                        string xmlCategory = getCategory.Attributes["cat"].Value;


                        if (chosenCategory.Equals(xmlCategory))
                        {

                            
                            getCategory.AppendChild(xmlFeed);
                        }

                    }

                }


            }


        }



        public override void addElements(string rssName)
        {

            XmlElement podElement = doc.CreateElement("item");
            XmlElement titleElement = doc.CreateElement("title");
            XmlElement podCast = doc.CreateElement("pod");
            XmlElement podurl = doc.CreateElement("enclosure");
            XmlElement podStatus = doc.CreateElement("status");
            XmlElement podDescription = doc.CreateElement("description");

            titleElement.InnerText = title;
            podurl.InnerText = enclosure;
            podCast.InnerText = rssName;
            podStatus.InnerText = status;
            podDescription.InnerText = description;


            podElement.AppendChild(titleElement);
            podElement.AppendChild(podurl);
            podElement.AppendChild(podCast);
            podElement.AppendChild(podStatus);
            podElement.AppendChild(podDescription);
            feedElement.AppendChild(podElement);
            string path = Directory.GetCurrentDirectory() + @"\XMLBase.xml";
            doc.Save(path);
        }






        public static void change(string buttonText)
        {
            doc = Ressfetch.fetchBase();


            foreach (XmlNode xmlTitle in doc.DocumentElement.SelectNodes("category/feed/item"))
            {
                string title = xmlTitle.SelectSingleNode("title").InnerText;


                if (title.Equals(buttonText))
                {

                    xmlTitle.SelectSingleNode("status").InnerText = "1";
                    Console.WriteLine(title);
                    Console.WriteLine("korv");
                    string path = Directory.GetCurrentDirectory() + @"\XMLBase.xml";
                    doc.Save(path);
             //       doc.Save(@"C:\Users\Tobias\Source\Repos\Bajjen\data\XMLBase.xml");
                }
            }
        }

        public static void deleteCategory(string deleteCategory)
        {
            doc = Ressfetch.fetchBase();

           
            foreach (XmlNode xmlCategory in doc.DocumentElement.SelectNodes("category"))
            {

                string checkCategory = xmlCategory.Attributes["cat"].Value;
                if (checkCategory.Equals(deleteCategory)) xmlCategory.ParentNode.RemoveChild(xmlCategory);
                string path = Directory.GetCurrentDirectory() + @"\XMLBase.xml";
                doc.Save(path);
            }

        }


        public static void deleteFeed(string deleteFeed) {

            foreach (XmlNode xmlFeed in doc.DocumentElement.SelectNodes("category/feed"))
            {

                string check = xmlFeed.Attributes["feed"].Value;

                if (check.Equals(deleteFeed)) xmlFeed.ParentNode.RemoveChild(xmlFeed);

                string path = Directory.GetCurrentDirectory() + @"\XMLBase.xml";
                doc.Save(path);

            }



        }



        public static void change(string oldName, string newName)
        {
            doc = Ressfetch.fetchBase();

            foreach (XmlNode xmlFeed in doc.DocumentElement.SelectNodes("category/feed"))
            {
                string check = xmlFeed.Attributes["feed"].Value;
                

                if (check.Equals(oldName)) xmlFeed.Attributes["feed"].Value = newName;
                string path = Directory.GetCurrentDirectory() + @"\XMLBase.xml";
                doc.Save(path);

            }

          

        }


        public static void changeUrl(string oldName, string newUrl)
        {

            doc = Ressfetch.fetchBase();

            foreach (XmlNode xmlFeed in doc.DocumentElement.SelectNodes("category/feed"))
            {
                string check = xmlFeed.Attributes["feed"].Value;


                if (check.Equals(oldName)) xmlFeed.Attributes["url"].Value = newUrl;
                string path = Directory.GetCurrentDirectory() + @"\XMLBase.xml";
                doc.Save(path);

            }
        }


        public static void changeCategoryName(string oldName, string newName) {

            foreach (XmlNode xmlCategory in doc.DocumentElement.SelectNodes("category"))
            {

                string checkCategory = xmlCategory.Attributes["cat"].Value;
                if (checkCategory.Equals(oldName)) xmlCategory.Attributes["cat"].Value = newName;
                string path = Directory.GetCurrentDirectory() + @"\XMLBase.xml";
                doc.Save(path);
            }



        }


        public static void addCategory(string catName) {

           

            if (findDoubles.doubleCategory(catName) == false)
            {
                XmlElement category = doc.CreateElement("category");
                category.SetAttribute("cat", catName);
                doc.DocumentElement.AppendChild(category);
                string path = Directory.GetCurrentDirectory() + @"\XMLBase.xml";
                doc.Save(path);
            }

           


        }

        public static void changeInterval(string oldName, string newInterval)
        {

            doc = Ressfetch.fetchBase();

            foreach (XmlNode xmlFeed in doc.DocumentElement.SelectNodes("category/feed"))
            {
                string check = xmlFeed.Attributes["feed"].Value;


                if (check.Equals(oldName)) xmlFeed.Attributes["interval"].Value = newInterval;
                string path = Directory.GetCurrentDirectory() + @"\XMLBase.xml";
                doc.Save(path);


            }
        }

       

    }
}
