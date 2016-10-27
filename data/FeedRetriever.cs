using System;
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




        public static List<string> getFeed(string rssName, out string url)
        {

            titleList = new List<string>();


            doc = Ressfetch.fetchBase();

            url = "";

            foreach (XmlNode feed in doc.DocumentElement.SelectNodes("category/feed"))
            {
                string feedString = feed.Attributes["feed"].Value;

               
                if (rssName.Equals(feedString))
                {

                    foreach (XmlNode item in feed.ChildNodes) {

                        string title = item.SelectSingleNode("title").InnerText;

                        url = item.SelectSingleNode("enclosure").InnerText;
                        titleList.Add(title);


                    }



                }

            }


            return titleList;
           
        }

        public static List<string> getFeeds() {

            List<string> feedList = new List<string>();


            doc = Ressfetch.fetchBase();

            foreach (XmlNode item
                        in  doc.DocumentElement.SelectNodes("category/feed"))
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

    }
    }
