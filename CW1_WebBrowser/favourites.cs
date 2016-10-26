using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Newtonsoft.Json;
using System.Dynamic;

namespace CW1_WebBrowser
{
    public partial class favourites : Form
    {
        dynamic obj = new ExpandoObject();
        public string result;

        public favourites(string url)
        {
            InitializeComponent();
            urlWebsite_txtBox.Text = url;
        }

        private void cancel_favForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBookamrkBtn_Click(object sender, EventArgs e)
        {
            obj.URL_Bookmark = urlWebsite_txtBox.Text;
            obj.URL_Name = urlName_txtBox.Text;
            result = Newtonsoft.Json.JsonConvert.SerializeObject(obj);
            this.Close();
        }
    }
}
