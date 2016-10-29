namespace CW1_WebBrowser
{
    partial class ManageFavourites
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
            this.favourites_listBox = new System.Windows.Forms.ListBox();
            this.edit_Name = new System.Windows.Forms.Button();
            this.RemoveFav = new System.Windows.Forms.Button();
            this.openURL = new System.Windows.Forms.Button();
            this.closeManageFav = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // favourites_listBox
            // 
            this.favourites_listBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.favourites_listBox.FormattingEnabled = true;
            this.favourites_listBox.ItemHeight = 20;
            this.favourites_listBox.Location = new System.Drawing.Point(0, 0);
            this.favourites_listBox.Name = "favourites_listBox";
            this.favourites_listBox.Size = new System.Drawing.Size(690, 404);
            this.favourites_listBox.TabIndex = 0;
            this.favourites_listBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.favourites_listBox_Format);
            // 
            // edit_Name
            // 
            this.edit_Name.Location = new System.Drawing.Point(87, 410);
            this.edit_Name.Name = "edit_Name";
            this.edit_Name.Size = new System.Drawing.Size(128, 52);
            this.edit_Name.TabIndex = 1;
            this.edit_Name.Text = "Edit URL";
            this.edit_Name.UseVisualStyleBackColor = true;
            this.edit_Name.Click += new System.EventHandler(this.edit_Name_Click);
            // 
            // RemoveFav
            // 
            this.RemoveFav.Location = new System.Drawing.Point(236, 410);
            this.RemoveFav.Name = "RemoveFav";
            this.RemoveFav.Size = new System.Drawing.Size(144, 52);
            this.RemoveFav.TabIndex = 2;
            this.RemoveFav.Text = "Remove URL";
            this.RemoveFav.UseVisualStyleBackColor = true;
            // 
            // openURL
            // 
            this.openURL.Location = new System.Drawing.Point(396, 410);
            this.openURL.Name = "openURL";
            this.openURL.Size = new System.Drawing.Size(132, 52);
            this.openURL.TabIndex = 3;
            this.openURL.Text = "Open URL";
            this.openURL.UseVisualStyleBackColor = true;
            this.openURL.Click += new System.EventHandler(this.openURL_Click);
            // 
            // closeManageFav
            // 
            this.closeManageFav.Location = new System.Drawing.Point(549, 410);
            this.closeManageFav.Name = "closeManageFav";
            this.closeManageFav.Size = new System.Drawing.Size(132, 52);
            this.closeManageFav.TabIndex = 4;
            this.closeManageFav.Text = "Close Window";
            this.closeManageFav.UseVisualStyleBackColor = true;
            this.closeManageFav.Click += new System.EventHandler(this.closeManageFav_Click);
            // 
            // ManageFavourites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 474);
            this.Controls.Add(this.closeManageFav);
            this.Controls.Add(this.openURL);
            this.Controls.Add(this.RemoveFav);
            this.Controls.Add(this.edit_Name);
            this.Controls.Add(this.favourites_listBox);
            this.Name = "ManageFavourites";
            this.Text = "ManageFavourites";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox favourites_listBox;
        private System.Windows.Forms.Button edit_Name;
        private System.Windows.Forms.Button RemoveFav;
        private System.Windows.Forms.Button openURL;
        private System.Windows.Forms.Button closeManageFav;
    }
}