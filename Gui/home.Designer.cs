namespace Gui
{
    partial class Home
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
            this.feedsList = new System.Windows.Forms.ListBox();
            this.categoriesList = new System.Windows.Forms.ListBox();
            this.podcastsList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // feedsList
            // 
            this.feedsList.FormattingEnabled = true;
            this.feedsList.ItemHeight = 16;
            this.feedsList.Location = new System.Drawing.Point(202, 12);
            this.feedsList.Name = "feedsList";
            this.feedsList.Size = new System.Drawing.Size(174, 452);
            this.feedsList.TabIndex = 0;
            // 
            // categoriesList
            // 
            this.categoriesList.FormattingEnabled = true;
            this.categoriesList.ItemHeight = 16;
            this.categoriesList.Location = new System.Drawing.Point(12, 12);
            this.categoriesList.Name = "categoriesList";
            this.categoriesList.Size = new System.Drawing.Size(164, 452);
            this.categoriesList.TabIndex = 1;
            // 
            // podcastsList
            // 
            this.podcastsList.FormattingEnabled = true;
            this.podcastsList.ItemHeight = 16;
            this.podcastsList.Location = new System.Drawing.Point(395, 13);
            this.podcastsList.Name = "podcastsList";
            this.podcastsList.Size = new System.Drawing.Size(178, 452);
            this.podcastsList.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 842);
            this.Controls.Add(this.podcastsList);
            this.Controls.Add(this.categoriesList);
            this.Controls.Add(this.feedsList);
            this.Name = "Home";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox feedsList;
        private System.Windows.Forms.ListBox categoriesList;
        private System.Windows.Forms.ListBox podcastsList;
    }
}

