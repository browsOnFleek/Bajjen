using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data
{
    public class Podcast
    {
        public string title { get; set; }
        public string clicked { get; set; }
        public string description { get; set; }

        public Podcast(string newTitle, string newClicked, string newDescription) {

            title = newTitle;
            clicked = newClicked;
            description = newDescription;


        }

    }
}
