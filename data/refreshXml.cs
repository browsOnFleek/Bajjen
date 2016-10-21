using System;
using System.Threading.Tasks;
using System.Threading;

namespace data
{
    public static class RefreshXml
    {

        public static bool _isActive;

        public static async void startXmlRefresher(int sleeptime, string url)
        {

         
            _isActive = true;


            await  xmlRefresh(sleeptime, url);
         



        }

        public static Task xmlRefresh(int sleeptime, string url) {


            return Task.Run(() =>
            {


                while (_isActive)
                {

                    var dom = Ressfetch.fetchRss(url);
                    RssWriter.writeExisting(dom);

                    Console.WriteLine("done");

                    if (_isActive) Thread.Sleep(sleeptime);

                }


            });


        }


    }
}
