using System;
using System.Windows.Forms;


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

            Panel panels = new Panel();

            Label labels = new Label();

            labels.Text = textBox2.Text;

            panels.Controls.Add(labels);

            panels.BackColor = System.Drawing.SystemColors.ActiveCaption;
      
           
            panels.Size = new System.Drawing.Size(153, 63);
            panels.TabIndex = 0;

            flowLayout2.Controls.Add(panels);

           

           

            data.RefreshXml.startXmlRefresher(30000, inputBox.Text);

            listBox1.Items.Add(textBox1.Text);




        }

       
    }
}
