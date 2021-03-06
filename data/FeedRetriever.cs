﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace data
{
    public static class FeedRetriever
    {
        private static XmlDocument doc;


        private static List<string> titleList;
        private static List<Podcast> podList;



        public static List<Podcast> getFeed(string rssName)
        {

            podList = new List<Podcast>();


            doc = Ressfetch.fetchBase();

        
            foreach (XmlNode feed in doc.DocumentElement.SelectNodes("category/feed"))
            {
                string feedString = feed.Attributes["feed"].Value;


                if (rssName.Equals(feedString))
                {

                    foreach (XmlNode item in feed.ChildNodes)
                    {

                        string title = item.SelectSingleNode("title").InnerText;

                        string clicked = item.SelectSingleNode("status").InnerText;

                        string description = "n00b";

                        Podcast pod = new Podcast(title, clicked, description);
                        
                        
                        podList.Add(pod);


                    }



                }

            }


            return podList;

        }

        public static List<string> getFeeds()
        {

            List<string> feedList = new List<string>();


            doc = Ressfetch.fetchBase();

            foreach (XmlNode item
                        in doc.DocumentElement.SelectNodes("category/feed"))
            {

                string check = item.Attributes["feed"].Value;
                Console.WriteLine(check);

                feedList.Add(check);



            }

            List<string> distinctFeedList = feedList.Distinct().ToList();

            return distinctFeedList;


        }

        public static List<string> getCats()
        {

            List<string> feedList = new List<string>();


            doc = Ressfetch.fetchBase();

            foreach (XmlNode item
                        in doc.DocumentElement.SelectNodes("category"))
            {

                string check = item.Attributes["cat"].Value;
                Console.WriteLine(check);

                feedList.Add(check);
            }

            List<string> distinctFeedList = feedList.Distinct().ToList();

            return distinctFeedList;



        }

        public static List<string> getCatFeeds(string category)
        {
            List<string> feedList = new List<string>();


            doc = Ressfetch.fetchBase();
            
            foreach (XmlNode item
                        in doc.DocumentElement.SelectNodes("category"))
            {

                string check = item.Attributes["cat"].Value;
                if (check.Equals(category))
                {
                    foreach (XmlNode catfeeds in item.ChildNodes)
                    {
                        string feed = catfeeds.Attributes["feed"].Value;



                        feedList.Add(feed);
                    }

                }


            }

            List<string> distinctFeedList = feedList.Distinct().ToList();

            return distinctFeedList;

        }

        public static string getEnclosure( string buttonText)
        {
            doc = Ressfetch.fetchBase();
           string url = "";
            
            
            foreach (XmlNode xmlTitle in doc.DocumentElement.SelectNodes("category/feed/item"))
            {
                string title = xmlTitle.SelectSingleNode("title").InnerText;
                

                if (title.Equals(buttonText))
                {
                    url = xmlTitle.SelectSingleNode("enclosure").InnerText;
                    
                }


              
            }
            return url;
        }





        public static string getUrl(string feedName)
        {
            doc = Ressfetch.fetchBase();
            string url = "";

            foreach (XmlNode xmlattributes in doc.DocumentElement.SelectNodes("category/feed"))
            {
                string xmlFeedName = xmlattributes.Attributes["feed"].Value;
                if (xmlFeedName.Equals(feedName))
                {
                    url = xmlattributes.Attributes["url"].Value;
                }
            }
            return url;
        }

        public static string getInterval(string feedName) {


            doc = Ressfetch.fetchBase();
            string url = "";

            foreach (XmlNode xmlattributes in doc.DocumentElement.SelectNodes("category/feed"))
            {
                string xmlFeedName = xmlattributes.Attributes["feed"].Value;
                if (xmlFeedName.Equals(feedName))
                {
                    url = xmlattributes.Attributes["interval"].Value;
                }
            }
            return url;



        }


        public static string getDescription(string buttonText)
        {
            doc = Ressfetch.fetchBase();
            string description = "";

            foreach (XmlNode xmlitem in doc.DocumentElement.SelectNodes("category/feed/item"))
            {
                string title = xmlitem.SelectSingleNode("title").InnerText;
                if (title.Equals(buttonText))
                {
                    description = xmlitem.SelectSingleNode("description").InnerText; 
                }
            }
            return description;
        }



    }
}
