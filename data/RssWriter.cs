using System.Xml;
using System;

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


        public static void appendFeedToCategory() {




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
            doc.Save(@"C:\Users\Tobias\Source\Repos\Bajjen\data\XMLBase.xml");
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

                    doc.Save(@"C:\Users\Tobias\Source\Repos\Bajjen\data\XMLBase.xml");
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
                doc.Save(@"C:\Users\Tobias\Source\Repos\Bajjen\data\XMLBase.xml");
            }

        }


        public static void deleteFeed(string deleteFeed) {

            foreach (XmlNode xmlFeed in doc.DocumentElement.SelectNodes("category/feed"))
            {

                string check = xmlFeed.Attributes["feed"].Value;

                if (check.Equals(deleteFeed)) xmlFeed.ParentNode.RemoveChild(xmlFeed);

                doc.Save(@"C:\Users\Tobias\Source\Repos\Bajjen\data\XMLBase.xml");

            }



        }



        public static void change(string oldName, string newName)
        {
            doc = Ressfetch.fetchBase();

            foreach (XmlNode xmlFeed in doc.DocumentElement.SelectNodes("category/feed"))
            {
                string check = xmlFeed.Attributes["feed"].Value;
                

                if (check.Equals(oldName)) xmlFeed.Attributes["feed"].Value = newName;
                doc.Save(@"C:\Users\Tobias\Source\Repos\Bajjen\data\XMLBase.xml");
             
            }

          

        }


        public static void changeUrl(string oldName, string newUrl)
        {

            doc = Ressfetch.fetchBase();

            foreach (XmlNode xmlFeed in doc.DocumentElement.SelectNodes("category/feed"))
            {
                string check = xmlFeed.Attributes["feed"].Value;


                if (check.Equals(oldName)) xmlFeed.Attributes["url"].Value = newUrl;
                doc.Save(@"C:\Users\Tobias\Source\Repos\Bajjen\data\XMLBase.xml");

            }
        }


        public static void changeCategoryName(string oldName, string newName) {

            foreach (XmlNode xmlCategory in doc.DocumentElement.SelectNodes("category"))
            {

                string checkCategory = xmlCategory.Attributes["cat"].Value;
                if (checkCategory.Equals(oldName)) xmlCategory.Attributes["cat"].Value = newName;
                doc.Save(@"C:\Users\Tobias\Source\Repos\Bajjen\data\XMLBase.xml");
            }



        }


        public static void addCategory(string catName) {

           

            if (findDoubles.doubleCategory(catName) == false)
            {
                XmlElement category = doc.CreateElement("category");
                category.SetAttribute("cat", catName);
                doc.DocumentElement.AppendChild(category);
                doc.Save(@"C:\Users\Tobias\Source\Repos\Bajjen\data\XMLBase.xml");
            }

           


        }

        public static void changeInterval(string oldName, string newInterval)
        {

            doc = Ressfetch.fetchBase();

            foreach (XmlNode xmlFeed in doc.DocumentElement.SelectNodes("category/feed"))
            {
                string check = xmlFeed.Attributes["feed"].Value;


                if (check.Equals(oldName)) xmlFeed.Attributes["interval"].Value = newInterval;
                doc.Save(@"C:\Users\Tobias\Source\Repos\Bajjen\data\XMLBase.xml");


            }
        }

       

    }
}
