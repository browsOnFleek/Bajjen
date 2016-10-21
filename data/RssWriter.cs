using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace data
{
    public class RssWriter
    {





        public int added = 0;



        public void writeExisting(XmlDocument dom)
        {

            var y = 0;

            foreach (XmlNode channelItem
               in dom.DocumentElement.SelectNodes("channel/item"))
            {
                int number = 0;
                bool exist = false;

                var title = channelItem.SelectSingleNode("title").InnerText;

                XmlDocument doc = new XmlDocument();
                doc.Load(@"C:\Users\jonas\documents\visual studio 2015\Projects\Bajjen\data\XMLBase.xml");



                foreach (XmlNode podItem
                     in doc.DocumentElement.SelectNodes("item"))
                {
                    number = number + 1;

                }

                if (number == 0)
                {

                    addElements(doc, title);


                }

                else
                {

                    foreach (XmlNode item
                      in doc.DocumentElement.SelectNodes("item"))
                    {


                        Console.WriteLine("if");
                        string check = item.SelectSingleNode("title").InnerText;

                        if (title.Equals(check))
                        {
                            exist = true;

                        }


                    }


                    if (exist == false)
                    {


                        addElements(doc, title);
                    }
                }

                Console.WriteLine(added);
            }

        }


        public void addElements(XmlDocument doc, string title)
        {

            XmlElement podElement = doc.CreateElement("item");
            XmlElement titleElement = doc.CreateElement("title");
            titleElement.InnerText = title;

            added++;

            podElement.AppendChild(titleElement);
            doc.DocumentElement.AppendChild(podElement);
            doc.Save(@"C:\Users\jonas\documents\visual studio 2015\Projects\Bajjen\data\XMLBase.xml");



        }
    }
}
