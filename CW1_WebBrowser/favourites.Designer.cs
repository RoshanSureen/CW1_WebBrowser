namespace CW1_WebBrowser
{
    partial class favourites
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
            this.cancel_favForm = new System.Windows.Forms.Button();
            this.url_Website = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.url_Name = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.saveBookamrkBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cancel_favForm
            // 
            this.cancel_favForm.Location = new System.Drawing.Point(238, 142);
            this.cancel_favForm.Name = "cancel_favForm";
            this.cancel_favForm.Size = new System.Drawing.Size(85, 35);
            this.cancel_favForm.TabIndex = 0;
            this.cancel_favForm.Text = "Cancel";
            this.cancel_favForm.UseVisualStyleBackColor = true;
            this.cancel_favForm.Click += new System.EventHandler(this.cancel_favForm_Click);
            // 
            // url_Website
            // 
            this.url_Website.AutoSize = true;
            this.url_Website.Location = new System.Drawing.Point(12, 9);
            this.url_Website.Name = "url_Website";
            this.url_Website.Size = new System.Drawing.Size(122, 20);
            this.url_Website.TabIndex = 1;
            this.url_Website.Text = "URL of Website";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(450, 26);
            this.textBox1.TabIndex = 2;
            // 
            // url_Name
            // 
            this.url_Name.AutoSize = true;
            this.url_Name.Location = new System.Drawing.Point(12, 75);
            this.url_Name.Name = "url_Name";
            this.url_Name.Size = new System.Drawing.Size(177, 20);
            this.url_Name.TabIndex = 3;
            this.url_Name.Text = "Name of your bookmark";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(11, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(450, 26);
            this.textBox2.TabIndex = 4;
            // 
            // saveBookamrkBtn
            // 
            this.saveBookamrkBtn.Location = new System.Drawing.Point(129, 142);
            this.saveBookamrkBtn.Name = "saveBookamrkBtn";
            this.saveBookamrkBtn.Size = new System.Drawing.Size(85, 35);
            this.saveBookamrkBtn.TabIndex = 5;
            this.saveBookamrkBtn.Text = "Save";
            this.saveBookamrkBtn.UseVisualStyleBackColor = true;
            // 
            // favourites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 189);
            this.Controls.Add(this.saveBookamrkBtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.url_Name);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.url_Website);
            this.Controls.Add(this.cancel_favForm);
            this.MaximumSize = new System.Drawing.Size(495, 245);
            this.MinimizeBox = false;
            this.Name = "favourites";
            this.Text = "favourites";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_favForm;
        private System.Windows.Forms.Label url_Website;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label url_Name;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button saveBookamrkBtn;
    }
}