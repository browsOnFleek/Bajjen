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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // feedList
            // 
            this.feedList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.feedList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.feedList.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.feedList.FormattingEnabled = true;
            this.feedList.ItemHeight = 28;
            this.feedList.Location = new System.Drawing.Point(13, 188);
            this.feedList.Name = "feedList";
            this.feedList.Size = new System.Drawing.Size(250, 532);
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
            this.button1.Location = new System.Drawing.Point(1633, 630);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "ADD POD FEED";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(1701, 482);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(227, 22);
            this.inputBox.TabIndex = 2;
            // 
            // flowLayout
            // 
            this.flowLayout.AutoScroll = true;
            this.flowLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.flowLayout.Location = new System.Drawing.Point(352, 188);
            this.flowLayout.Margin = new System.Windows.Forms.Padding(20);
            this.flowLayout.Name = "flowLayout";
            this.flowLayout.Padding = new System.Windows.Forms.Padding(20);
            this.flowLayout.Size = new System.Drawing.Size(804, 560);
            this.flowLayout.TabIndex = 3;
            // 
            // flowLayout2
            // 
            this.flowLayout2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.flowLayout2.Location = new System.Drawing.Point(13, 13);
            this.flowLayout2.Name = "flowLayout2";
            this.flowLayout2.Size = new System.Drawing.Size(1594, 86);
            this.flowLayout2.TabIndex = 4;
            // 
            // feedNameBox
            // 
            this.feedNameBox.Location = new System.Drawing.Point(1701, 402);
            this.feedNameBox.Name = "feedNameBox";
            this.feedNameBox.Size = new System.Drawing.Size(161, 22);
            this.feedNameBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(1696, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "URL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(1696, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "FEED NAME";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1701, 188);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 22);
            this.textBox2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1696, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "CATEGORY";
            // 
            // CatLabel
            // 
            this.CatLabel.AutoSize = true;
            this.CatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CatLabel.Location = new System.Drawing.Point(41, 136);
            this.CatLabel.Name = "CatLabel";
            this.CatLabel.Size = new System.Drawing.Size(167, 29);
            this.CatLabel.TabIndex = 12;
            this.CatLabel.Text = "POD FEEDS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(1697, 526);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "INTERVAL";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "30 sec",
            "1 min",
            "5 min"});
            this.comboBox1.Location = new System.Drawing.Point(1701, 571);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 24);
            this.comboBox1.TabIndex = 15;
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(0, 777);
            this.mediaPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(1954, 45);
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
            this.deleteCategoryButton.Location = new System.Drawing.Point(1430, 285);
            this.deleteCategoryButton.Name = "deleteCategoryButton";
            this.deleteCategoryButton.Size = new System.Drawing.Size(177, 74);
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
            this.change.Location = new System.Drawing.Point(1804, 630);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(124, 68);
            this.change.TabIndex = 19;
            this.change.Text = "UPDATE POD FEED";
            this.change.UseVisualStyleBackColor = false;
            this.change.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1432, 471);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(217, 22);
            this.textBox3.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(1434, 434);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "NEW CATEGORY NAME";
            // 
            // FeedLabel
            // 
            this.FeedLabel.AutoSize = true;
            this.FeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeedLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FeedLabel.Location = new System.Drawing.Point(682, 136);
            this.FeedLabel.Name = "FeedLabel";
            this.FeedLabel.Size = new System.Drawing.Size(64, 25);
            this.FeedLabel.TabIndex = 24;
            this.FeedLabel.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(1297, 602);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 29);
            this.label7.TabIndex = 23;
            this.label7.Text = "DESCRIPTION";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(1202, 630);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(387, 118);
            this.richTextBox1.TabIndex = 22;
            this.richTextBox1.Text = "";
            // 
            // addCategory
            // 
            this.addCategory.Location = new System.Drawing.Point(1701, 244);
            this.addCategory.Name = "addCategory";
            this.addCategory.Size = new System.Drawing.Size(158, 67);
            this.addCategory.TabIndex = 25;
            this.addCategory.Text = "Add Category";
            this.addCategory.UseVisualStyleBackColor = true;
            this.addCategory.Click += new System.EventHandler(this.addCategory_Click);
            // 
            // deleteFeedButton
            // 
            this.deleteFeedButton.Location = new System.Drawing.Point(1430, 188);
            this.deleteFeedButton.Name = "deleteFeedButton";
            this.deleteFeedButton.Size = new System.Drawing.Size(177, 76);
            this.deleteFeedButton.TabIndex = 26;
            this.deleteFeedButton.Text = "DELETE FEED";
            this.deleteFeedButton.UseVisualStyleBackColor = true;
            this.deleteFeedButton.Click += new System.EventHandler(this.deleteFeedButton_Click);
            // 
            // changeCatNameButton
            // 
            this.changeCatNameButton.Location = new System.Drawing.Point(1432, 514);
            this.changeCatNameButton.Name = "changeCatNameButton";
            this.changeCatNameButton.Size = new System.Drawing.Size(175, 60);
            this.changeCatNameButton.TabIndex = 29;
            this.changeCatNameButton.Text = "CHANGE CATEGORY NAME";
            this.changeCatNameButton.UseVisualStyleBackColor = true;
            this.changeCatNameButton.Click += new System.EventHandler(this.changeCatNameButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1954, 822);
            this.Controls.Add(this.changeCatNameButton);
            this.Controls.Add(this.deleteFeedButton);
            this.Controls.Add(this.addCategory);
            this.Controls.Add(this.FeedLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.change);
            this.Controls.Add(this.deleteCategoryButton);
            this.Controls.Add(this.mediaPlayer);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CatLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.feedNameBox);
            this.Controls.Add(this.flowLayout2);
            this.Controls.Add(this.flowLayout);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.feedList);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBox1;
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
    }
}

