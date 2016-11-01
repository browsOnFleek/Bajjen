using System;
using System.Threading.Tasks;
using System.Threading;

namespace data
{
    public static class RefreshXml
    {

        public static bool _isActive;

        public static async void startXmlRefresher(int sleeptime, string url, string rssName)
        {

         
            _isActive = true;


            await  xmlRefresh(sleeptime, url, rssName);

            Console.WriteLine("laddar om");


        }

        public static Task xmlRefresh(int sleeptime, string url, string rssName) {


            return Task.Run(() =>
            {


                while (_isActive)
                {

                    var dom = Ressfetch.fetchRss(url);
                    XmlEditor.writeExisting(dom, rssName);

                    if (_isActive) Thread.Sleep(sleeptime);

                }


            });


        }


    }
}
