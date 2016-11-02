using System;
using System.Windows.Forms;
using System.Collections.Generic;

using System.Xml;
using System.Threading.Tasks;
using System.Threading;

namespace Bajjen
{
    public partial class Form1 : Form
    {
        private bool _isActive;

        public Form1()
        {
            InitializeComponent();
            drawFeedList();
            drawCategoryList();


        }




        public void drawFeedList()
        {

            List<string> feeds = data.FeedRetriever.getFeeds();

            foreach (string feed in feeds)
            {
                feedList.Items.Add(feed);
            }

        }


       public Button drawPlayButton(data.Podcast item)
        {

            Button playButtons = new Button();
            playButtons.Text = item.title;


            playButtons.BackColor = System.Drawing.SystemColors.ActiveCaption;
            playButtons.Size = new System.Drawing.Size(130, 63);
            playButtons.TabIndex = 0;
            playButtons.FlatAppearance.BorderSize = 0;
            playButtons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            playButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            playButtons.ForeColor = System.Drawing.SystemColors.ButtonHighlight;

            if (item.clicked.Equals("1"))
            {
                playButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));



            }

            playButtons.Click += playButtons_click;

            return playButtons;
        }



        public void drawCategoryList()
        {


            List<string> cats = data.FeedRetriever.getCats();
            foreach (string cat in cats)
            {
                Button buttons = new Button();
                buttons.Text = cat;
                buttons.FlatAppearance.BorderSize = 0;
                buttons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                buttons.BackColor = System.Drawing.SystemColors.ActiveCaption;
                buttons.Size = new System.Drawing.Size(153, 63);

                buttons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
                buttons.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                buttons.TabIndex = 0;

                buttons.Click += catButton_click;


                flowLayout2.Controls.Add(buttons);
            }

        }







        private void button1_Click(object sender, EventArgs e)
        {
            bool _empty = false;
            List<string> feeds = data.FeedRetriever.getFeeds();


            string rssName = feedNameBox.Text;
            string chosenCategory = CatLabel.Text;
            string url = inputBox.Text;

           string interval = chooseInterval();

            if (interval.Equals("nothing"))
            {
                _empty = true;
            }
            if (data.Validation.emptyString(rssName))
             {
                _empty = true;
            }
            if (data.Validation.emptyString(url))
            {
                _empty = true;
            }
            if (data.Validation.emptyString(chosenCategory))
            {
                _empty = true;
            }
            if (feeds.Contains(rssName))
            {
                MessageBox.Show("Feednamnet finns redan.");
            }
            if (_empty)
            {
                MessageBox.Show("Någon ruta va tom");
            }
            else
            {
                var dom = data.Ressfetch.fetchRss(inputBox.Text);
                data.RssWriter.addFeed(dom, rssName, chosenCategory, interval, url);

                feedList.Items.Clear();
                flowLayout2.Controls.Clear();

                drawFeedList();

                drawCategoryList();
            }


        }





        private async void feedList_Click(object sender, EventArgs e)
        {

            flowLayout.Controls.Clear();

            int index = feedList.SelectedIndex;
            string rssName = feedList.Items[index].ToString();
            string url = "";
            FeedLabel.Text = rssName;
            string 
            List<Button> btnList = await xmlRefresh(rssName);
            foreach (Button btn in btnList)
            {

                flowLayout.Controls.Add(btn);

            }

            data.RefreshXml.startXmlRefresher(10000, "http://api.sr.se/api/rss/pod/22209", rssName);
        }










        private void catButton_click(object sender, EventArgs e)
        {
            feedList.Items.Clear();


            Button button = sender as Button;

            string cat = button.Text;
            CatLabel.Text = cat;

            List<string> feeds = data.FeedRetriever.getCatFeeds(cat);

            foreach (string feed in feeds)
            {

                feedList.Items.Add(feed);




            }

        }


        private void playButtons_click(object sender, EventArgs e)
        {

            richTextBox1.Clear();
            Button button = sender as Button;
            string buttonText = button.Text;
            data.RssWriter.change(buttonText);
            string url = data.FeedRetriever.getEnclosure(buttonText);
            string description = data.FeedRetriever.getDescription(buttonText);
            richTextBox1.Text = description;
            Console.WriteLine(url);
            mediaPlayer.URL = url;
        }





        private void deleteButton_Click(object sender, EventArgs e)
        {
         
            string deleteCategory = CatLabel.Text;
            if(data.Validation.emptyString(deleteCategory) == false)
            {
                data.RssWriter.deleteCategory(deleteCategory);
                feedList.Items.Clear();
                flowLayout2.Controls.Clear();


            drawFeedList();
            drawCategoryList();

            }
            else
            {
                MessageBox.Show("Tryck på den kategori du vill ta bort.");
            }
            

        }

        





        public Task<List<Button>> xmlRefresh(string rssName)
        {


            return Task.Run(() =>
            {
                List<Button> podList = new List<Button>();



                foreach (data.Podcast item in data.FeedRetriever.getFeed(rssName))
                {

                    podList.Add(drawPlayButton(item));
                }

                return podList;

            });


        }








        private void changeButton_Click(object sender, EventArgs e)
        {



            


            string oldName = FeedLabel.Text;

            string newInterval = intervalBox.Text;
            string newUrl = inputBox.Text;
            string newName = feedNameBox.Text;
            chooseInterval();

            
            if (data.Validation.emptyString(newUrl) == false)
            {
                data.RssWriter.changeUrl(oldName, newUrl);
            }
            if (data.Validation.emptyString(newInterval) == false)
            {
                data.RssWriter.changeInterval(oldName, newInterval);
            }


            if (data.Validation.emptyString(newName) == false)
            {

                data.RssWriter.change(oldName, newName);
            }
            if (data.Validation.emptyString(oldName) == true)
            {

                MessageBox.Show("tryck på den feed du vill byta namn på");
            
            }

            feedList.Items.Clear();
            flowLayout2.Controls.Clear();

            drawFeedList();

            drawCategoryList();
        }

        




        private void addCategory_Click(object sender, EventArgs e)
        {
            
            string catName = textBox2.Text;
            List<string> cats = data.FeedRetriever.getCats();

            if ((data.Validation.emptyString(catName)) || (cats.Contains(catName)))
            {
                MessageBox.Show("Det finns redan en kategori vid det namnet eller så är namnrutan tom");
            }
            else
            {
               

                data.RssWriter.addCategory(catName);

                feedList.Items.Clear();
                flowLayout2.Controls.Clear();

                drawFeedList();

                drawCategoryList();
            }
            


        }

        private void deleteFeedButton_Click(object sender, EventArgs e)
        {



            string feedName = FeedLabel.Text;
            
            if (data.Validation.emptyString(feedName) == false)
            {
                data.RssWriter.deleteFeed(feedName);

                feedList.Items.Clear();
                flowLayout2.Controls.Clear();


                drawFeedList();
                drawCategoryList();
                
            }
            else
            {
                MessageBox.Show("Tryck på den feed du vill ta bort.");
            }
                
        }

        private void changeCatNameButton_Click(object sender, EventArgs e)
        {

            string newName = textBox3.Text;
            string oldName = CatLabel.Text;
            if (data.Validation.emptyString(oldName) == true)
            {
                MessageBox.Show("Vänligen tryck på den kategori du vill byta namn på.");
            }
            if (data.Validation.emptyString(newName) == true)
            {
                MessageBox.Show("Skriv vilket namn kategorin ska få.");
            }
            else
            {
                data.RssWriter.changeCategoryName(oldName, newName);

                feedList.Items.Clear();
                flowLayout2.Controls.Clear();

                drawFeedList();

                drawCategoryList();
            }
            


        }

        public string chooseInterval()
        {
            string interval = "";
            if (intervalBox.Text.Equals("30 sec"))
            {
                interval = "30000";
            }
            else if (intervalBox.Text.Equals("1 min"))
            {
                interval = "60000";
            }
            else if (intervalBox.Text.Equals("5 min"))
            {
                interval = "300000";
            }
            else
            {
                interval = "nothing";
            }

            return interval;
        }

        private void changeCategoryButton_Click(object sender, EventArgs e)
        {
            string chosenCategory = appendCatBox.Text;
            string feedName = FeedLabel.Text;
            string url = data.FeedRetriever.getUrl(feedName);
            string interval = data.FeedRetriever.getInterval(feedName);
            List<string> cats = data.FeedRetriever.getCats();
            Console.WriteLine(url);

            if ((data.Validation.emptyString(feedName) == false) && (cats.Contains(chosenCategory)))
            {
                data.RssWriter.deleteFeed(feedName);

                var dom = data.Ressfetch.fetchRss(inputBox.Text);
                data.RssWriter.addFeed(dom, feedName, chosenCategory, interval, url);

                feedList.Items.Clear();
                flowLayout2.Controls.Clear();


                drawFeedList();
                drawCategoryList();

            }
            else
            {
                MessageBox.Show("Tryck på den feed du vill ändra.");
            }



        }
    }


}
