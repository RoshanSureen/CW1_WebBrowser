namespace CW1_WebBrowser
{
    partial class add_Bookmark
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
            this.addBookmark_btn = new System.Windows.Forms.Button();
            this.cancelBokmark_btn = new System.Windows.Forms.Button();
            this.name_of_bookmark = new System.Windows.Forms.TextBox();
            this.url_of_Bookmark = new System.Windows.Forms.TextBox();
            this.url_BK_label = new System.Windows.Forms.Label();
            this.name_BK_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addBookmark_btn
            // 
            this.addBookmark_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addBookmark_btn.Location = new System.Drawing.Point(167, 148);
            this.addBookmark_btn.Name = "addBookmark_btn";
            this.addBookmark_btn.Size = new System.Drawing.Size(95, 35);
            this.addBookmark_btn.TabIndex = 0;
            this.addBookmark_btn.Text = "OK";
            this.addBookmark_btn.UseVisualStyleBackColor = true;
            // 
            // cancelBokmark_btn
            // 
            this.cancelBokmark_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBokmark_btn.Location = new System.Drawing.Point(287, 148);
            this.cancelBokmark_btn.Name = "cancelBokmark_btn";
            this.cancelBokmark_btn.Size = new System.Drawing.Size(95, 35);
            this.cancelBokmark_btn.TabIndex = 1;
            this.cancelBokmark_btn.Text = "Cancel";
            this.cancelBokmark_btn.UseVisualStyleBackColor = true;
            // 
            // name_of_bookmark
            // 
            this.name_of_bookmark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name_of_bookmark.Location = new System.Drawing.Point(16, 32);
            this.name_of_bookmark.Name = "name_of_bookmark";
            this.name_of_bookmark.Size = new System.Drawing.Size(370, 26);
            this.name_of_bookmark.TabIndex = 2;
            // 
            // url_of_Bookmark
            // 
            this.url_of_Bookmark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.url_of_Bookmark.Location = new System.Drawing.Point(16, 107);
            this.url_of_Bookmark.Name = "url_of_Bookmark";
            this.url_of_Bookmark.Size = new System.Drawing.Size(370, 26);
            this.url_of_Bookmark.TabIndex = 3;
            // 
            // url_BK_label
            // 
            this.url_BK_label.AutoSize = true;
            this.url_BK_label.Location = new System.Drawing.Point(12, 9);
            this.url_BK_label.Name = "url_BK_label";
            this.url_BK_label.Size = new System.Drawing.Size(139, 20);
            this.url_BK_label.TabIndex = 4;
            this.url_BK_label.Text = "URL Of Bookmark";
            // 
            // name_BK_Label
            // 
            this.name_BK_Label.AutoSize = true;
            this.name_BK_Label.Location = new System.Drawing.Point(12, 75);
            this.name_BK_Label.Name = "name_BK_Label";
            this.name_BK_Label.Size = new System.Drawing.Size(148, 20);
            this.name_BK_Label.TabIndex = 5;
            this.name_BK_Label.Text = "Name Of Bookmark";
            // 
            // add_Bookmark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 188);
            this.Controls.Add(this.name_BK_Label);
            this.Controls.Add(this.url_BK_label);
            this.Controls.Add(this.url_of_Bookmark);
            this.Controls.Add(this.name_of_bookmark);
            this.Controls.Add(this.cancelBokmark_btn);
            this.Controls.Add(this.addBookmark_btn);
            this.Name = "add_Bookmark";
            this.Text = "add_Bookmark";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBookmark_btn;
        private System.Windows.Forms.Button cancelBokmark_btn;
        private System.Windows.Forms.TextBox name_of_bookmark;
        private System.Windows.Forms.TextBox url_of_Bookmark;
        private System.Windows.Forms.Label url_BK_label;
        private System.Windows.Forms.Label name_BK_Label;
    }
}