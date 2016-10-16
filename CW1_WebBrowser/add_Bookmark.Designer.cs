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
            this.url_bookmark = new System.Windows.Forms.TextBox();
            this.name_bookmark = new System.Windows.Forms.TextBox();
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
            this.cancelBokmark_btn.Click += new System.EventHandler(this.cancelBokmark_btn_Click);
            // 
            // url_bookmark
            // 
            this.url_bookmark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.url_bookmark.Location = new System.Drawing.Point(16, 32);
            this.url_bookmark.Name = "url_bookmark";
            this.url_bookmark.Size = new System.Drawing.Size(370, 26);
            this.url_bookmark.TabIndex = 2;
            // 
            // name_bookmark
            // 
            this.name_bookmark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name_bookmark.Location = new System.Drawing.Point(16, 107);
            this.name_bookmark.Name = "name_bookmark";
            this.name_bookmark.Size = new System.Drawing.Size(370, 26);
            this.name_bookmark.TabIndex = 3;
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
            this.Controls.Add(this.name_bookmark);
            this.Controls.Add(this.url_bookmark);
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
        private System.Windows.Forms.TextBox url_bookmark;
        private System.Windows.Forms.TextBox name_bookmark;
        private System.Windows.Forms.Label url_BK_label;
        private System.Windows.Forms.Label name_BK_Label;
    }
}