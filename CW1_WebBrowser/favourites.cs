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
using Newtonsoft.Json.Converters;

namespace CW1_WebBrowser
{
    public partial class favourites : Form
    {
        public string result;

        public static dynamic bookmarkDetails = new ExpandoObject();
        IDictionary<string,object> dictionary = (IDictionary<string, object>)bookmarkDetails;

        public favourites(string url)
        {
            InitializeComponent();
            urlWebsite_txtBox.Text = url;
        }
        

        public IDictionary<string, object> GetDictionary()
        {
            return dictionary;
        }

        
        private void saveBookamrkBtn_Click(object sender, EventArgs e)
        {
            string name1 = urlWebsite_txtBox.Text;
            string name2 = urlName_txtBox.Text;
            
            addBookmarkToFile(name1,name2);
            this.Close();
        }


        private void addBookmarkToFile(string urlToAdd, string urlNameToAdd)
        {
            dictionary.Add(urlToAdd,urlNameToAdd);
        }


        private void cancel_favForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
