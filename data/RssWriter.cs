﻿using System.Xml;
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
            doc.Save(@"C:\Users\jonas\documents\visual studio 2015\Projects\Bajjen\data\XMLBase.xml");
        }






        public static void changeStatus(string buttonText)
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

                    doc.Save(@"C:\Users\jonas\documents\visual studio 2015\Projects\Bajjen\data\XMLBase.xml");
                }
            }
        }

        public static void deleteFeed(string deleteFeed, string deleteCategory)
        {
            doc = Ressfetch.fetchBase();

            foreach (XmlNode xmlFeed in doc.DocumentElement.SelectNodes("category/feed"))
            {

                string check = xmlFeed.Attributes["feed"].Value;


                if (check.Equals(deleteFeed)) xmlFeed.ParentNode.RemoveChild(xmlFeed);

                    doc.Save(@"C:\Users\jonas\documents\visual studio 2015\Projects\Bajjen\data\XMLBase.xml");

                

    
                }
            foreach (XmlNode xmlCategory in doc.DocumentElement.SelectNodes("category"))
            {
                
                string checkCategory = xmlCategory.Attributes["cat"].Value;
                if (checkCategory.Equals(deleteCategory)) xmlCategory.ParentNode.RemoveChild(xmlCategory);
                doc.Save(@"C:\Users\jonas\documents\visual studio 2015\Projects\Bajjen\data\XMLBase.xml");
            }

            }
    }
}
