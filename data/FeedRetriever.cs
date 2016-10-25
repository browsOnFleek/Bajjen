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
        public static List<string> getFeed(string rssName)
        {

            titleList = new List<string>();


            doc = Ressfetch.fetchBase();

            foreach (XmlNode item
                          in doc.DocumentElement.SelectNodes(rssName + "/item"))
            {

                string check = item.SelectSingleNode("title").InnerText;

                titleList.Add(check);

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

        }
    }
