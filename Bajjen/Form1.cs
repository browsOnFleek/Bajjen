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

                List<string> cats = data.FeedRetriever.getCats();
                foreach (string cat in cats)
                {
                    Button buttons = new Button();
                    buttons.Text = cat;

                    buttons.BackColor = System.Drawing.SystemColors.ActiveCaption;
                    buttons.Size = new System.Drawing.Size(153, 63);
                    buttons.TabIndex = 0;

                    buttons.Click += btn1_click;


                    flowLayout2.Controls.Add(buttons);
                }
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
            data.RssWriter.writeExisting(dom, rssName, chosenCategory);

            



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
                buttons.TabIndex = 0;
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

            

            foreach (string item in data.FeedRetriever.getFeed(rssName))
            {



                Panel panels = new Panel();

                Label labels = new Label();

                labels.Text = item;

                panels.Controls.Add(labels);

                panels.BackColor = System.Drawing.SystemColors.ActiveCaption;


                panels.Size = new System.Drawing.Size(153, 63);
                panels.TabIndex = 0;

                flowLayout.Controls.Add(panels);

            }
        }



        private void btn1_click(object sender, EventArgs e) {

            Button button = sender as Button;

            string cat = button.Text; 
            
           

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


    }
}
