using System;
using System.Windows.Forms;
using System.Collections.Generic;

using System.Xml;

namespace Bajjen
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            List<string> feeds = data.FeedRetriever.getFeeds();

            foreach (string feed in feeds) {

                listBox1.Items.Add(feed);

                
                }

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

                buttons.Click += btn1_click;


                flowLayout2.Controls.Add(buttons);
            }


        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           


            var dom = data.Ressfetch.fetchRss(inputBox.Text);
            string rssName = textBox1.Text;
            string chosenCategory = textBox2.Text;


            string interval = "10000";
            data.RssWriter.writeExisting(dom, rssName, chosenCategory, interval);

            listBox1.Items.Clear();
            flowLayout2.Controls.Clear();

            List<string> feeds = data.FeedRetriever.getFeeds();
            foreach (string feed in feeds)
            {
                listBox1.Items.Add(feed);
            }

            List<string> cats = data.FeedRetriever.getCats();
            foreach (string cat in cats)
            {

                Button buttons = new Button();
                buttons.Text = cat;

                buttons.BackColor = System.Drawing.SystemColors.ActiveCaption;
                buttons.Size = new System.Drawing.Size(153, 63);
                buttons.FlatAppearance.BorderSize = 0;
                buttons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                buttons.TabIndex = 0;
                buttons.Click += btn1_click;
                flowLayout2.Controls.Add(buttons);
            }



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

        private void listBox1_Click(object sender, EventArgs e)
        {

            flowLayout.Controls.Clear();

            int hello = listBox1.SelectedIndex;
            string rssName = listBox1.Items[hello].ToString();
            string url = "";
            

            foreach (string item in data.FeedRetriever.getFeed(rssName, out url))
            {


                Button playButtons = new Button();
                playButtons.Text = item;

                playButtons.BackColor = System.Drawing.SystemColors.ActiveCaption;
                playButtons.Size = new System.Drawing.Size(130, 63);
                playButtons.TabIndex = 0;
                playButtons.FlatAppearance.BorderSize = 0;
                playButtons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                playButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
                playButtons.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                playButtons.Click += playButtons_click;
                flowLayout.Controls.Add(playButtons);



            }
        }



        private void btn1_click(object sender, EventArgs e) {
            listBox1.Items.Clear();


            Button button = sender as Button;

            string cat = button.Text;
            List<string> feeds = data.FeedRetriever.getCatFeeds(cat);

            foreach (string feed in feeds)
            {

                listBox1.Items.Add(feed);




            }

            }


        private void playButtons_click(object sender, EventArgs e)
        {
            string url;

            int hello = listBox1.SelectedIndex;
            string rssName = listBox1.Items[hello].ToString();
            data.FeedRetriever.getFeed(rssName, out url);
            mediaPlayer.URL = url;
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayout2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
