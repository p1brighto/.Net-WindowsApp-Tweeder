namespace Assignment_2
{
    partial class twitterForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(twitterForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tweetHandleOrHashLabel = new System.Windows.Forms.Label();
            this.tweetsLabel = new System.Windows.Forms.Label();
            this.searchUserButton = new System.Windows.Forms.Button();
            this.searchHashButton = new System.Windows.Forms.Button();
            this.TweetHandleTextBox = new System.Windows.Forms.TextBox();
            this.TweetsCountTextBox = new System.Windows.Forms.TextBox();
            this.TweetsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tweetHandleOrHashLabel
            // 
            resources.ApplyResources(this.tweetHandleOrHashLabel, "tweetHandleOrHashLabel");
            this.tweetHandleOrHashLabel.Name = "tweetHandleOrHashLabel";
            // 
            // tweetsLabel
            // 
            resources.ApplyResources(this.tweetsLabel, "tweetsLabel");
            this.tweetsLabel.Name = "tweetsLabel";
            // 
            // searchUserButton
            // 
            resources.ApplyResources(this.searchUserButton, "searchUserButton");
            this.searchUserButton.Name = "searchUserButton";
            this.searchUserButton.UseVisualStyleBackColor = true;
            this.searchUserButton.Click += new System.EventHandler(this.searchUserButton_Click);
            // 
            // searchHashButton
            // 
            resources.ApplyResources(this.searchHashButton, "searchHashButton");
            this.searchHashButton.Name = "searchHashButton";
            this.searchHashButton.UseVisualStyleBackColor = true;
            this.searchHashButton.Click += new System.EventHandler(this.searchHashButton_Click);
            // 
            // TweetHandleTextBox
            // 
            resources.ApplyResources(this.TweetHandleTextBox, "TweetHandleTextBox");
            this.TweetHandleTextBox.Name = "TweetHandleTextBox";
            this.toolTip.SetToolTip(this.TweetHandleTextBox, resources.GetString("TweetHandleTextBox.ToolTip"));
            // 
            // TweetsCountTextBox
            // 
            resources.ApplyResources(this.TweetsCountTextBox, "TweetsCountTextBox");
            this.TweetsCountTextBox.Name = "TweetsCountTextBox";
            this.toolTip.SetToolTip(this.TweetsCountTextBox, resources.GetString("TweetsCountTextBox.ToolTip"));
            // 
            // TweetsRichTextBox
            // 
            resources.ApplyResources(this.TweetsRichTextBox, "TweetsRichTextBox");
            this.TweetsRichTextBox.Name = "TweetsRichTextBox";
            this.TweetsRichTextBox.ReadOnly = true;
            this.TweetsRichTextBox.TabStop = false;
            this.toolTip.SetToolTip(this.TweetsRichTextBox, resources.GetString("TweetsRichTextBox.ToolTip"));
            // 
            // twitterForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TweetsRichTextBox);
            this.Controls.Add(this.TweetsCountTextBox);
            this.Controls.Add(this.TweetHandleTextBox);
            this.Controls.Add(this.searchHashButton);
            this.Controls.Add(this.searchUserButton);
            this.Controls.Add(this.tweetsLabel);
            this.Controls.Add(this.tweetHandleOrHashLabel);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "twitterForm";
            this.Load += new System.EventHandler(this.TwitterForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label tweetHandleOrHashLabel;
        private System.Windows.Forms.Label tweetsLabel;
        private System.Windows.Forms.Button searchUserButton;
        private System.Windows.Forms.Button searchHashButton;
        private System.Windows.Forms.TextBox TweetHandleTextBox;
        private System.Windows.Forms.TextBox TweetsCountTextBox;
        private System.Windows.Forms.RichTextBox TweetsRichTextBox;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

