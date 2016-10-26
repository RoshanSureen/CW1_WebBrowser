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
using System.Diagnostics;

namespace CW1_WebBrowser
{
    public partial class favourites : Form
    {
        HW_Browser browser = new HW_Browser();
        
        public favourites()
        {
            InitializeComponent();
        }

        private void cancel_favForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBookamrkBtn_Click(object sender, EventArgs e)
        {
            string bookmark_URL_To_Add = urlWebsite_txtBox.Text;
            string name_Of_URL_To_ADD = urlName_txtBox.Text;
            addBookmark(bookmark_URL_To_Add,name_Of_URL_To_ADD);
        }

        private void addBookmark(string website_URL,string name_URL)
        {

            if (browser.myList == null)
            {
                browser.myList = new List<bookmarkDetails>();
                browser.myList.Add(new bookmarkDetails(website_URL,name_URL));
            }
            
            browser.myList.Add(new bookmarkDetails(website_URL,name_URL));
            MessageBox.Show("URL added to favourites!");
            Debug.WriteLine(browser.myList);
        }

        
    }

    public class bookmarkDetails
    {
        public string URL_bookmark { get; set; }
        public string URL_name { get; set; }

        public bookmarkDetails(string WebSite_URL, string Name_URL)
        {
            this.URL_bookmark = WebSite_URL;
            this.URL_name = Name_URL;
        }
    }
}
