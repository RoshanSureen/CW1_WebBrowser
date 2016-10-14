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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.favToolStripMenuItem});
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
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.newWindowToolStripMenuItem.Text = "New Window";
            // 
            // goIncognitoToolStripMenuItem
            // 
            this.goIncognitoToolStripMenuItem.Name = "goIncognitoToolStripMenuItem";
            this.goIncognitoToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.goIncognitoToolStripMenuItem.Text = "Go Incognito";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.exitToolStripMenuItem.Text = "Exit";
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
            this.viewHistoryToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.viewHistoryToolStripMenuItem.Text = "View History";
            // 
            // deleteHistoryToolStripMenuItem
            // 
            this.deleteHistoryToolStripMenuItem.Name = "deleteHistoryToolStripMenuItem";
            this.deleteHistoryToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
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
            // HW_Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 844);
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
    }
}

