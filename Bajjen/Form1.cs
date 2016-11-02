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


            var dom = data.Ressfetch.fetchRss(inputBox.Text);
            string rssName = feedNameBox.Text;
            string chosenCategory = CatLabel.Text;
            string url = inputBox.Text;

            string interval = "";
            if (comboBox1.Text.Equals("30 sec"))
            {
                interval = "30000";
            }
            else if (comboBox1.Text.Equals("1 min"))
            {
                interval = "60000";
            }
            else if (comboBox1.Text.Equals("5 min"))
            {
                interval = "300000";
            }
            else
            {
                MessageBox.Show("Please choose an interval!");
            }


            data.RssWriter.addFeed(dom, rssName, chosenCategory, interval, url);

            feedList.Items.Clear();
            flowLayout2.Controls.Clear();

            drawFeedList();

            drawCategoryList();



        }





        private async void feedList_Click(object sender, EventArgs e)
        {

            flowLayout.Controls.Clear();

            int index = feedList.SelectedIndex;
            string rssName = feedList.Items[index].ToString();
            string url = "";
            FeedLabel.Text = rssName;

            List<Button> btnList = await xmlRefresh(rssName);
            foreach (Button btn in btnList)
            {

                flowLayout.Controls.Add(btn);

            }

            data.RefreshXml.startXmlRefresher(10000, "http://alexosigge.libsyn.com/rss", rssName);
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
            data.RssWriter.deleteCategory(deleteCategory);

            feedList.Items.Clear();
            flowLayout2.Controls.Clear();


            drawFeedList();
            drawCategoryList();

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


            string newUrl = inputBox.Text;
            string newName = feedNameBox.Text;

            if (data.Validation.notEmpty(newName))
            {

                data.RssWriter.change(oldName, newName);

            }
            if (data.Validation.notEmpty(newUrl))
            {
                data.RssWriter.changeUrl(oldName, newUrl);
            }


            feedList.Items.Clear();
            flowLayout2.Controls.Clear();

            drawFeedList();

            drawCategoryList();
        }

        




        private void addCategory_Click(object sender, EventArgs e)
        {

            string catName = textBox2.Text;
            data.RssWriter.addCategory(catName);

            feedList.Items.Clear();
            flowLayout2.Controls.Clear();

            drawFeedList();

            drawCategoryList();

        }

        private void deleteFeedButton_Click(object sender, EventArgs e)
        {



            string feedName = FeedLabel.Text;
            data.RssWriter.deleteFeed(feedName);

            feedList.Items.Clear();
            flowLayout2.Controls.Clear();


            drawFeedList();
            drawCategoryList();

        }

        private void changeCatNameButton_Click(object sender, EventArgs e)
        {

            string newName = textBox3.Text;
            string oldName = CatLabel.Text;

            data.RssWriter.changeCategoryName(oldName, newName);


            feedList.Items.Clear();
            flowLayout2.Controls.Clear();

            drawFeedList();

            drawCategoryList();

        }
    }


}
