using System;
using System.Windows.Forms;
using System.Collections.Generic;


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

            

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Panel panels = new Panel();

            Label labels = new Label();

            labels.Text = textBox2.Text;

            panels.Controls.Add(labels);

            panels.BackColor = System.Drawing.SystemColors.ActiveCaption;
      
           
            panels.Size = new System.Drawing.Size(153, 63);
            panels.TabIndex = 0;

            flowLayout2.Controls.Add(panels);



            var dom = data.Ressfetch.fetchRss(inputBox.Text);
            string rssName = textBox1.Text;
            
            
            data.RssWriter.writeExisting(dom, rssName,);

            listBox1.Items.Add(textBox1.Text);




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
    }
}
