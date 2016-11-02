namespace Bajjen
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.feedList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.flowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayout2 = new System.Windows.Forms.FlowLayoutPanel();
            this.feedNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CatLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.intervalBox = new System.Windows.Forms.ComboBox();
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.deleteCategoryButton = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FeedLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.addCategory = new System.Windows.Forms.Button();
            this.deleteFeedButton = new System.Windows.Forms.Button();
            this.changeCatNameButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.changeCategoryButton = new System.Windows.Forms.Button();
            this.appendCatBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // feedList
            // 
            this.feedList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.feedList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.feedList.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.feedList.FormattingEnabled = true;
            this.feedList.ItemHeight = 36;
            this.feedList.Location = new System.Drawing.Point(15, 235);
            this.feedList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.feedList.Name = "feedList";
            this.feedList.Size = new System.Drawing.Size(175, 648);
            this.feedList.TabIndex = 0;
            this.feedList.Click += new System.EventHandler(this.feedList_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(15, 301);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 85);
            this.button1.TabIndex = 1;
            this.button1.Text = "ADD POD FEED";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(9, 145);
            this.inputBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(225, 26);
            this.inputBox.TabIndex = 2;
            // 
            // flowLayout
            // 
            this.flowLayout.AutoScroll = true;
            this.flowLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.flowLayout.Location = new System.Drawing.Point(242, 235);
            this.flowLayout.Margin = new System.Windows.Forms.Padding(22, 25, 22, 25);
            this.flowLayout.Name = "flowLayout";
            this.flowLayout.Padding = new System.Windows.Forms.Padding(22, 25, 22, 25);
            this.flowLayout.Size = new System.Drawing.Size(904, 700);
            this.flowLayout.TabIndex = 3;
            // 
            // flowLayout2
            // 
            this.flowLayout2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.flowLayout2.Location = new System.Drawing.Point(15, 16);
            this.flowLayout2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayout2.Name = "flowLayout2";
            this.flowLayout2.Size = new System.Drawing.Size(1793, 108);
            this.flowLayout2.TabIndex = 4;
            // 
            // feedNameBox
            // 
            this.feedNameBox.Location = new System.Drawing.Point(9, 51);
            this.feedNameBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.feedNameBox.Name = "feedNameBox";
            this.feedNameBox.Size = new System.Drawing.Size(181, 26);
            this.feedNameBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(3, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "URL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "FEED NAME";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(17, 75);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(222, 26);
            this.textBox2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "CATEGORY";
            // 
            // CatLabel
            // 
            this.CatLabel.AutoSize = true;
            this.CatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CatLabel.Location = new System.Drawing.Point(46, 170);
            this.CatLabel.Name = "CatLabel";
            this.CatLabel.Size = new System.Drawing.Size(0, 36);
            this.CatLabel.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(3, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 32);
            this.label5.TabIndex = 14;
            this.label5.Text = "INTERVAL";
            // 
            // intervalBox
            // 
            this.intervalBox.FormattingEnabled = true;
            this.intervalBox.Items.AddRange(new object[] {
            "30 sec",
            "1 min",
            "5 min"});
            this.intervalBox.Location = new System.Drawing.Point(15, 246);
            this.intervalBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.intervalBox.Name = "intervalBox";
            this.intervalBox.Size = new System.Drawing.Size(148, 28);
            this.intervalBox.TabIndex = 15;
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(0, 983);
            this.mediaPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(1912, 45);
            this.mediaPlayer.TabIndex = 17;
            // 
            // deleteCategoryButton
            // 
            this.deleteCategoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.deleteCategoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteCategoryButton.FlatAppearance.BorderSize = 0;
            this.deleteCategoryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.deleteCategoryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.deleteCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCategoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCategoryButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteCategoryButton.Location = new System.Drawing.Point(1327, 362);
            this.deleteCategoryButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteCategoryButton.Name = "deleteCategoryButton";
            this.deleteCategoryButton.Size = new System.Drawing.Size(164, 68);
            this.deleteCategoryButton.TabIndex = 18;
            this.deleteCategoryButton.Text = "DELETE CATEGORY";
            this.deleteCategoryButton.UseVisualStyleBackColor = false;
            this.deleteCategoryButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // change
            // 
            this.change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.change.Cursor = System.Windows.Forms.Cursors.Hand;
            this.change.FlatAppearance.BorderSize = 0;
            this.change.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.change.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.change.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.change.Location = new System.Drawing.Point(182, 301);
            this.change.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(151, 85);
            this.change.TabIndex = 19;
            this.change.Text = "UPDATE POD FEED";
            this.change.UseVisualStyleBackColor = false;
            this.change.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(17, 70);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(210, 26);
            this.textBox3.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(12, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(269, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "NEW CATEGORY NAME";
            // 
            // FeedLabel
            // 
            this.FeedLabel.AutoSize = true;
            this.FeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeedLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FeedLabel.Location = new System.Drawing.Point(767, 170);
            this.FeedLabel.Name = "FeedLabel";
            this.FeedLabel.Size = new System.Drawing.Size(0, 29);
            this.FeedLabel.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(1171, 697);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 32);
            this.label7.TabIndex = 23;
            this.label7.Text = "DESCRIPTION";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(1176, 749);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(271, 146);
            this.richTextBox1.TabIndex = 22;
            this.richTextBox1.Text = "";
            // 
            // addCategory
            // 
            this.addCategory.Location = new System.Drawing.Point(17, 129);
            this.addCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addCategory.Name = "addCategory";
            this.addCategory.Size = new System.Drawing.Size(178, 84);
            this.addCategory.TabIndex = 25;
            this.addCategory.Text = "Add Category";
            this.addCategory.UseVisualStyleBackColor = true;
            this.addCategory.Click += new System.EventHandler(this.addCategory_Click);
            // 
            // deleteFeedButton
            // 
            this.deleteFeedButton.Location = new System.Drawing.Point(1177, 362);
            this.deleteFeedButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteFeedButton.Name = "deleteFeedButton";
            this.deleteFeedButton.Size = new System.Drawing.Size(139, 68);
            this.deleteFeedButton.TabIndex = 26;
            this.deleteFeedButton.Text = "DELETE FEED";
            this.deleteFeedButton.UseVisualStyleBackColor = true;
            this.deleteFeedButton.Click += new System.EventHandler(this.deleteFeedButton_Click);
            // 
            // changeCatNameButton
            // 
            this.changeCatNameButton.Location = new System.Drawing.Point(18, 124);
            this.changeCatNameButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.changeCatNameButton.Name = "changeCatNameButton";
            this.changeCatNameButton.Size = new System.Drawing.Size(197, 75);
            this.changeCatNameButton.TabIndex = 29;
            this.changeCatNameButton.Text = "CHANGE CATEGORY NAME";
            this.changeCatNameButton.UseVisualStyleBackColor = true;
            this.changeCatNameButton.Click += new System.EventHandler(this.changeCatNameButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.feedNameBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.inputBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.intervalBox);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.change);
            this.panel1.Location = new System.Drawing.Point(1536, 505);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 406);
            this.panel1.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.addCategory);
            this.panel2.Location = new System.Drawing.Point(1536, 203);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 247);
            this.panel2.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(60)))));
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.changeCatNameButton);
            this.panel3.Location = new System.Drawing.Point(1177, 453);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(314, 213);
            this.panel3.TabIndex = 32;
            // 
            // changeCategoryButton
            // 
            this.changeCategoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.changeCategoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeCategoryButton.FlatAppearance.BorderSize = 0;
            this.changeCategoryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.changeCategoryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.changeCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeCategoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeCategoryButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changeCategoryButton.Location = new System.Drawing.Point(1240, 236);
            this.changeCategoryButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.changeCategoryButton.Name = "changeCategoryButton";
            this.changeCategoryButton.Size = new System.Drawing.Size(164, 68);
            this.changeCategoryButton.TabIndex = 33;
            this.changeCategoryButton.Text = "APPEND TO CATEGORY";
            this.changeCategoryButton.UseVisualStyleBackColor = false;
            this.changeCategoryButton.Click += new System.EventHandler(this.changeCategoryButton_Click);
            // 
            // appendCatBox
            // 
            this.appendCatBox.Location = new System.Drawing.Point(1206, 180);
            this.appendCatBox.Name = "appendCatBox";
            this.appendCatBox.Size = new System.Drawing.Size(252, 26);
            this.appendCatBox.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1912, 1028);
            this.Controls.Add(this.appendCatBox);
            this.Controls.Add(this.changeCategoryButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deleteFeedButton);
            this.Controls.Add(this.FeedLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.deleteCategoryButton);
            this.Controls.Add(this.mediaPlayer);
            this.Controls.Add(this.CatLabel);
            this.Controls.Add(this.flowLayout2);
            this.Controls.Add(this.flowLayout);
            this.Controls.Add(this.feedList);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox feedList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayout;
        private System.Windows.Forms.FlowLayoutPanel flowLayout2;
        private System.Windows.Forms.TextBox feedNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CatLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox intervalBox;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private System.Windows.Forms.Button deleteCategoryButton;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label FeedLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button addCategory;
        private System.Windows.Forms.Button deleteFeedButton;
        private System.Windows.Forms.Button changeCatNameButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button changeCategoryButton;
        private System.Windows.Forms.TextBox appendCatBox;
    }
}

