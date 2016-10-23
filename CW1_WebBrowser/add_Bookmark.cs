using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Web.Script.Serialization;
using System.IO;
using System.Threading;

namespace CW1_WebBrowser
{
    public partial class add_Bookmark : Form
    {
        private string currentURL;
        private string currentURL_name;
        //public List<add_Bookmark> bookmark_List;


        public add_Bookmark(string currentURL, string currentURL_name)
        {
            InitializeComponent();
            this.currentURL = currentURL;
            this.currentURL_name = currentURL_name;
            Initialize_URL_Field();
        }

        private void cancelBokmark_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Initialize_URL_Field()
        {
            url_bookmark.Text = currentURL;
        }

        private void addBookmark_btn_Click(object sender, EventArgs e)
        {
            currentURL_name = name_bookmark.Text;
            AddBookamrk bk = new AddBookamrk();
            bk.Favourites(currentURL,currentURL_name);
        }

        
    }

    public class AddBookamrk
    {
        public void Favourites(string websiteURl, string websiteURLName)
        {
            //if (File.Exists("bookmark.json"))
            //{
            //    string list_of_bookmark = File.ReadAllText("bookmark.json");
            //    List<add_Bookmark> myBookmarkList = JsonConvert.DeserializeObject<List<add_Bookmark>>(list_of_bookmark);

            //    if(myBookmarkList == null)
            //        myBookmarkList = new List<add_Bookmark>();

            //    myBookmarkList.Add(new add_Bookmark(websiteURl,websiteURLName));

            //    string add_Bookmark_To_List = JsonConvert.SerializeObject(myBookmarkList);
            //    File.WriteAllText("bookmark.json",add_Bookmark_To_List);
            //}
            //else
            //{
            //    List<add_Bookmark> myBookmarkList = new List<add_Bookmark>();
            //    myBookmarkList.Add(new add_Bookmark(websiteURl,websiteURLName));
            //    string add_Bookmark_To_List = JsonConvert.SerializeObject(myBookmarkList);
            //    File.WriteAllText("bookmark.json",add_Bookmark_To_List);
            //}

            //string list_of_bookmark = File.ReadAllText("bookmark.json");
            //List<add_Bookmark> myBookmarkList = JsonConvert.DeserializeObject<List<add_Bookmark>>(list_of_bookmark);

            //if (myBookmarkList == null)
            //    myBookmarkList = new List<add_Bookmark>();

            //myBookmarkList.Add(new add_Bookmark(websiteURl, websiteURLName));

            //string add_Bookmark_To_List = JsonConvert.SerializeObject(myBookmarkList, new JsonSerializerSettings()
            //{
            //    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize
            //});
            //File.WriteAllText("bookmark.json", add_Bookmark_To_List);
        }
    }
}
