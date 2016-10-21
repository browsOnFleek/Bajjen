using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;


namespace Bajjen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {




            data.RefreshXml refresh = new data.RefreshXml();

            refresh.startXmlRefresher(30000, inputBox.Text);






        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("hora");
        }
    }
}
