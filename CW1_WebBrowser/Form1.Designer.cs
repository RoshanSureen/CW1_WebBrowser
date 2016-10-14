namespace CW1_WebBrowser
{
    partial class HW_Browser
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goIncognitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookmarkThisPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.url_textBox = new System.Windows.Forms.TextBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.nextPage_btn = new System.Windows.Forms.Button();
            this.home_Btn = new System.Windows.Forms.Button();
            this.search_Btn = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.newTab_Btn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.favToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1278, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripMenuItem,
            this.goIncognitoToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(203, 30);
            this.newWindowToolStripMenuItem.Text = "New Window";
            // 
            // goIncognitoToolStripMenuItem
            // 
            this.goIncognitoToolStripMenuItem.Name = "goIncognitoToolStripMenuItem";
            this.goIncognitoToolStripMenuItem.Size = new System.Drawing.Size(203, 30);
            this.goIncognitoToolStripMenuItem.Text = "Go Incognito";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(203, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHistoryToolStripMenuItem,
            this.deleteHistoryToolStripMenuItem});
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.historyToolStripMenuItem.Text = "History";
            // 
            // viewHistoryToolStripMenuItem
            // 
            this.viewHistoryToolStripMenuItem.Name = "viewHistoryToolStripMenuItem";
            this.viewHistoryToolStripMenuItem.Size = new System.Drawing.Size(209, 30);
            this.viewHistoryToolStripMenuItem.Text = "View History";
            // 
            // deleteHistoryToolStripMenuItem
            // 
            this.deleteHistoryToolStripMenuItem.Name = "deleteHistoryToolStripMenuItem";
            this.deleteHistoryToolStripMenuItem.Size = new System.Drawing.Size(209, 30);
            this.deleteHistoryToolStripMenuItem.Text = "Delete History";
            // 
            // favToolStripMenuItem
            // 
            this.favToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToListToolStripMenuItem,
            this.bookmarkThisPageToolStripMenuItem});
            this.favToolStripMenuItem.Name = "favToolStripMenuItem";
            this.favToolStripMenuItem.Size = new System.Drawing.Size(104, 29);
            this.favToolStripMenuItem.Text = "Favourites";
            // 
            // addToListToolStripMenuItem
            // 
            this.addToListToolStripMenuItem.Name = "addToListToolStripMenuItem";
            this.addToListToolStripMenuItem.Size = new System.Drawing.Size(256, 30);
            this.addToListToolStripMenuItem.Text = "Manage bookmarks";
            // 
            // bookmarkThisPageToolStripMenuItem
            // 
            this.bookmarkThisPageToolStripMenuItem.Name = "bookmarkThisPageToolStripMenuItem";
            this.bookmarkThisPageToolStripMenuItem.Size = new System.Drawing.Size(256, 30);
            this.bookmarkThisPageToolStripMenuItem.Text = "Bookmark this page";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // url_textBox
            // 
            this.url_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.url_textBox.Location = new System.Drawing.Point(220, 36);
            this.url_textBox.Name = "url_textBox";
            this.url_textBox.Size = new System.Drawing.Size(864, 26);
            this.url_textBox.TabIndex = 1;
            this.url_textBox.Text = "http://";
            this.url_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.url_textBox_KeyPress);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(12, 36);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(60, 35);
            this.back_btn.TabIndex = 2;
            this.back_btn.Text = "back";
            this.back_btn.UseVisualStyleBackColor = true;
            // 
            // nextPage_btn
            // 
            this.nextPage_btn.Location = new System.Drawing.Point(78, 36);
            this.nextPage_btn.Name = "nextPage_btn";
            this.nextPage_btn.Size = new System.Drawing.Size(60, 35);
            this.nextPage_btn.TabIndex = 3;
            this.nextPage_btn.Text = "Next";
            this.nextPage_btn.UseVisualStyleBackColor = true;
            // 
            // home_Btn
            // 
            this.home_Btn.Location = new System.Drawing.Point(144, 36);
            this.home_Btn.Name = "home_Btn";
            this.home_Btn.Size = new System.Drawing.Size(70, 35);
            this.home_Btn.TabIndex = 4;
            this.home_Btn.Text = "Home";
            this.home_Btn.UseVisualStyleBackColor = true;
            // 
            // search_Btn
            // 
            this.search_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_Btn.Location = new System.Drawing.Point(1090, 36);
            this.search_Btn.Name = "search_Btn";
            this.search_Btn.Size = new System.Drawing.Size(75, 35);
            this.search_Btn.TabIndex = 5;
            this.search_Btn.Text = "Search";
            this.search_Btn.UseVisualStyleBackColor = true;
            this.search_Btn.Click += new System.EventHandler(this.search_Btn_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox.Location = new System.Drawing.Point(12, 77);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(1254, 734);
            this.richTextBox.TabIndex = 6;
            this.richTextBox.Text = "";
            // 
            // newTab_Btn
            // 
            this.newTab_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newTab_Btn.Location = new System.Drawing.Point(1171, 36);
            this.newTab_Btn.Name = "newTab_Btn";
            this.newTab_Btn.Size = new System.Drawing.Size(95, 35);
            this.newTab_Btn.TabIndex = 8;
            this.newTab_Btn.Text = "New Tab";
            this.newTab_Btn.UseVisualStyleBackColor = true;
            // 
            // HW_Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 844);
            this.Controls.Add(this.newTab_Btn);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.search_Btn);
            this.Controls.Add(this.home_Btn);
            this.Controls.Add(this.nextPage_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.url_textBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HW_Browser";
            this.Text = "HW_Browser";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goIncognitoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookmarkThisPageToolStripMenuItem;
        private System.Windows.Forms.TextBox url_textBox;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button nextPage_btn;
        private System.Windows.Forms.Button home_Btn;
        private System.Windows.Forms.Button search_Btn;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button newTab_Btn;
    }
}

