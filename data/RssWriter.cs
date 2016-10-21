using System.Xml;

namespace data
{
    public static class RssWriter
    {

        private static bool exist = false;
        private static int added = 0;
        private static bool _xmlEmpty = true;
        private static XmlDocument doc = Ressfetch.fetchBase();
        private static string title = "";


        public static void writeExisting(XmlDocument dom)
        {

            foreach (XmlNode channelItem
               in dom.DocumentElement.SelectNodes("channel/item"))
            {

                exist = false;
                _xmlEmpty = true;

                title = channelItem.SelectSingleNode("title").InnerText;

                seeIfXmlEmpty();

                if (_xmlEmpty)
                {
                    addElements();
                }

                else
                {
                    lookForDubble();
                }
            }
        }








        private static void addElements()
        {

            XmlElement podElement = doc.CreateElement("item");
            XmlElement titleElement = doc.CreateElement("title");
            titleElement.InnerText = title;

            added++;

            podElement.AppendChild(titleElement);
            doc.DocumentElement.AppendChild(podElement);
            doc.Save(@"C:\Users\jonas\documents\visual studio 2015\Projects\Bajjen\data\XMLBase.xml");
        }







        private static void lookForDubble()
        {


            foreach (XmlNode item
                      in doc.DocumentElement.SelectNodes("item"))
            {

                string check = item.SelectSingleNode("title").InnerText;

                if (title.Equals(check))
                {
                    exist = true;
                }
            }

            if (exist == false)
            {
                addElements();
            }
        }










        private static void seeIfXmlEmpty()
        {


            foreach (XmlNode podItem
                               in doc.DocumentElement.SelectNodes("item"))
            {

                _xmlEmpty = false;
            }
        }






    }
}
