namespace CW1_WebBrowser
{
    partial class ViewHistory
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
            this.HistoryListBox = new System.Windows.Forms.ListBox();
            this.OpenHistoryLinkBtn = new System.Windows.Forms.Button();
            this.closeViewHistory = new System.Windows.Forms.Button();
            this.deleteBTn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HistoryListBox
            // 
            this.HistoryListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HistoryListBox.FormattingEnabled = true;
            this.HistoryListBox.ItemHeight = 20;
            this.HistoryListBox.Location = new System.Drawing.Point(12, 6);
            this.HistoryListBox.Name = "HistoryListBox";
            this.HistoryListBox.Size = new System.Drawing.Size(875, 404);
            this.HistoryListBox.TabIndex = 0;
            // 
            // OpenHistoryLinkBtn
            // 
            this.OpenHistoryLinkBtn.Location = new System.Drawing.Point(320, 416);
            this.OpenHistoryLinkBtn.Name = "OpenHistoryLinkBtn";
            this.OpenHistoryLinkBtn.Size = new System.Drawing.Size(132, 52);
            this.OpenHistoryLinkBtn.TabIndex = 1;
            this.OpenHistoryLinkBtn.Text = "Open URL";
            this.OpenHistoryLinkBtn.UseVisualStyleBackColor = true;
            this.OpenHistoryLinkBtn.Click += new System.EventHandler(this.OpenHistoryLinkBtn_Click);
            // 
            // closeViewHistory
            // 
            this.closeViewHistory.Location = new System.Drawing.Point(734, 416);
            this.closeViewHistory.Name = "closeViewHistory";
            this.closeViewHistory.Size = new System.Drawing.Size(132, 52);
            this.closeViewHistory.TabIndex = 2;
            this.closeViewHistory.Text = "Close Window";
            this.closeViewHistory.UseVisualStyleBackColor = true;
            this.closeViewHistory.Click += new System.EventHandler(this.closeViewHistory_Click);
            // 
            // deleteBTn
            // 
            this.deleteBTn.Location = new System.Drawing.Point(596, 416);
            this.deleteBTn.Name = "deleteBTn";
            this.deleteBTn.Size = new System.Drawing.Size(132, 52);
            this.deleteBTn.TabIndex = 3;
            this.deleteBTn.Text = "Delete URL";
            this.deleteBTn.UseVisualStyleBackColor = true;
            this.deleteBTn.Click += new System.EventHandler(this.deleteBTn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(458, 416);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(132, 52);
            this.updateBtn.TabIndex = 4;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // ViewHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 474);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.deleteBTn);
            this.Controls.Add(this.closeViewHistory);
            this.Controls.Add(this.OpenHistoryLinkBtn);
            this.Controls.Add(this.HistoryListBox);
            this.Name = "ViewHistory";
            this.Text = "ViewHistory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewHistory_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox HistoryListBox;
        private System.Windows.Forms.Button OpenHistoryLinkBtn;
        private System.Windows.Forms.Button closeViewHistory;
        private System.Windows.Forms.Button deleteBTn;
        private System.Windows.Forms.Button updateBtn;
    }
}