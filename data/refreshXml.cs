using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Threading;

namespace data
{
    public class RefreshXml
    {

        public bool _isActive;

        public void startXmlRefresher(int sleeptime, string url)
        {

            Ressfetch fetcher = new Ressfetch();


            _isActive = true;
            RssWriter writer = new RssWriter();


            Task.Run(() =>
            {


                while (_isActive)
                {

                    var dom = fetcher.fetchRss(url);
                    writer.writeExisting(dom);

                    Console.WriteLine("done");

                    if (_isActive) Thread.Sleep(sleeptime);

                }


            });



        }

        public void startXmlRefresher(XmlDocument dom, int v)
        {
            throw new NotImplementedException();
        }
    }
}
