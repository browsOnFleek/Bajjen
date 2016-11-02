using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace data
{
    public abstract class BaseClass
    {
        private string description;
        private XmlDocument doc;
        private string enclosure;
        private string status;
        private string title;
        private XmlDocument feedElement;

        public virtual void addElements(string rssName)
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
            doc.Save(@"C:\Users\jonas\documents\visual studio 2015\Projects\Bajjen\data\XMLBase.xml");
        }




    }
}
