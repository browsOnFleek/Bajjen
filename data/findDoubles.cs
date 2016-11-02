using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace data
{
    public static class findDoubles
    {

        private static XmlDocument doc = Ressfetch.fetchBase();






        public static bool doublePods(string title)
        {

            bool exists = false;

            foreach (XmlNode item
                      in doc.DocumentElement.SelectNodes("category/feed/item"))
            {

                string check = item.SelectSingleNode("title").InnerText;

                if (title.Equals(check))
                {
                    exists = true;
                }
            }


            return exists;
        }



        public static bool doubleCategory(string catName) {


            bool _exists = false;

            foreach (XmlNode getCategory in doc.DocumentElement.SelectNodes("category"))
            {
                string xmlCategory = getCategory.Attributes["cat"].Value;


                if (catName.Equals(xmlCategory))
                {
                    _exists = true;


                }

            }

            return _exists;

        }




    }



}
