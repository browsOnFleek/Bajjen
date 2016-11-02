using System;
using System.Threading.Tasks;
using System.Threading;

namespace data
{
    public static class RefreshXml
    {

        public static bool _isActive;

        public static async void startXmlRefresher(string url, string rssName)
        {

         
            _isActive = true;


            await  xmlRefresh(url, rssName);

            Console.WriteLine("laddar om");


        }

        public static Task xmlRefresh(string url, string rssName) {


            return Task.Run(() =>
            {



                    var dom = Ressfetch.fetchRss(url);
                    XmlEditor.writeExisting(dom, rssName);

                  


            });


        }


    }
}
