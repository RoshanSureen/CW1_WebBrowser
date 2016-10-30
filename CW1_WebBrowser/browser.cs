using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http.ExceptionHandling;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Dynamic;
using System.Net.Configuration;
using System.Threading;
using HtmlAgilityPack;
using Newtonsoft.Json.Linq;

namespace CW1_WebBrowser
{
    public partial class HW_Browser : Form
    {
        /// <summary>
        /// object instances of different controls
        /// </summary>
        public TabPage tb;
        public RichTextBox newRich_TxtBox;

        /// <summary>
        /// Keep track of the current selected tab
        /// </summary>
        public TabPage currentTabPage { get; set; }
        public RichTextBox curRichTextBox { get; set; }

        /// <summary>
        /// class instances
        /// </summary>
        public favourites fav;
        public ManageFavourites manageFav;
        public ViewHistory ManageHistory;

        public string url_Value;
        public static int track_User_Histroy;
        public static string homePage;

        /// <summary>
        /// This dictionary is manupilated during the browser session for favourites
        /// </summary>
        public IDictionary<string, object> bookmarkDictionary_browser;

        /// <summary>
        /// This list keeps track of the user's history 
        /// </summary>
        private static List<string> list_browser = new List<string>();


        /// <summary>
        /// Initilizer for browser class
        /// </summary>
        public HW_Browser()
        {
            InitializeComponent();
            url_Value = "http://www.";
        }

        /// <summary>
        /// This function runs when the search btn is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void search_Btn_Click(object sender, EventArgs e)
        {
            string web_URL = url_textBox.Text;
            Get_Request(web_URL);
            
            list_browser.Add(url_textBox.Text);
            int historyCount = list_browser.Count;
            string currentURLInList = list_browser[historyCount - 1];
            track_User_Histroy = list_browser.IndexOf(currentURLInList);
        }

        /// <summary>
        /// This function ensures that the http request and response run on their own thread
        /// </summary>
        /// <param name="url"></param>
        async void Get_Request(string url)
        {
            // using() is used to dispose the client object when it goes out of scope
            using (HttpClient client = new HttpClient())
            {

                try
                {
                    // the client will wait for the request to be completed and then store the response in object 'res'
                    using (HttpResponseMessage res = await client.GetAsync(url))
                    {
                        if (res.IsSuccessStatusCode)
                        {
                            using (HttpContent content = res.Content)
                            {
                                string webContent = await content.ReadAsStringAsync();

                                //This part of the code is responsible for getting the title of the page from the HTML page
                                HtmlAgilityPack.HtmlDocument htmlDoc = new HtmlAgilityPack.HtmlDocument();
                                htmlDoc.OptionFixNestedTags = true;

                                htmlDoc.LoadHtml(webContent);

                                var tab_header = htmlDoc.DocumentNode.SelectSingleNode("//head/title");
                                string titleFromPage = WebUtility.HtmlDecode(tab_header.InnerText.Trim());

                                //The response and the title from the HTML page are sent to this function
                                DisplayWebContent(webContent, titleFromPage);
                            }
                        }
                        else
                        {
                            try
                            {
                                //Throws an exception if the IsSuccessStatusCode property for the HTTP response is false
                                res.EnsureSuccessStatusCode();
                            }
                            catch (Exception e)
                            {
                                string errorCode = res.StatusCode.ToString();
                                DisplayWebContent(e.Message, errorCode);
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    DisplayWebContent(e.Message, "bad request");
                }
            }
        }

        /// <summary>
        /// This is the core function that sets up the tabpage and rich textbox within the browser form to display the content
        /// </summary>
        /// <param name="content"></param>
        /// <param name="title"></param>
        private void DisplayWebContent(string content, string title)
        {
            if (currentTabPage == null)
            {
                tb = new TabPage(title);
                currentTabPage = tb;
                tabControl1.TabPages.Add(tb);
                newRich_TxtBox = new RichTextBox();
                curRichTextBox = newRich_TxtBox;
                tb.Controls.Add(newRich_TxtBox);
                newRich_TxtBox.Dock = DockStyle.Fill;
                newRich_TxtBox.Text = content;
            }
            else
            {
                if (tabControl1.SelectedTab.TabIndex == currentTabPage.TabIndex)
                {
                    currentTabPage.Text = title;
                    curRichTextBox.Text = content;
                }
                else
                {
                    currentTabPage = tabControl1.SelectedTab;
                    foreach (Control control in tabControl1.SelectedTab.Controls)
                    {
                        if (control is RichTextBox)
                        {
                            curRichTextBox = (RichTextBox)control;
                        }
                    }
                    currentTabPage.Text = title;
                    curRichTextBox.Text = content;
                }

            }

        }

        /// <summary>
        /// This function will run when the enter key is pushed and released
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void url_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if the keyStroke was enter then Get_Request()
            if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                search_Btn_Click(null, null);
            }
            back_btn.Enabled = true;
        }

        /// <summary>
        /// This function runs when the user wants to set a home page and clicks Home btn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void home_Btn_Click(object sender, EventArgs e)
        {
            string homePage = File.ReadAllText("home.txt");
            url_textBox.Text = homePage;
            Get_Request(homePage);
        }

        /// <summary>
        /// This function is responsoble for changing the home page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string homePage = url_textBox.Text;
            File.WriteAllText("home.txt", homePage);
            MessageBox.Show("This website is your current home page!");
        }


        /// <summary>
        /// This function runs when the new Tab button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newTab_Btn_Click(object sender, EventArgs e)
        {
            AddTabPage();
        }

        /// <summary>
        /// This function is responsible for adding a new tab.
        /// </summary>
        private void AddTabPage()
        {
            string title = "New Tab";
            tb = new TabPage(title);
            currentTabPage = tb;
            tabControl1.TabPages.Add(tb);
            tabControl1.SelectTab(tb);

            newRich_TxtBox = new RichTextBox();
            curRichTextBox = newRich_TxtBox;
            tb.Controls.Add(newRich_TxtBox);
            newRich_TxtBox.Dock = DockStyle.Fill;


            if (tb.Enabled)
            {
                url_textBox.Text = url_Value;
            }
        }

        /// <summary>
        /// This function closes the current working tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeTab_btn_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
        }

        /// <summary>
        /// This allows the user to bookmark his site
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bookmarkThisPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fav = new favourites(url_textBox.Text, Dictionary_Set);
            fav.Show();
        }

        /// <summary>
        /// retrun dictionary on browser class
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, object> Dictionary_Get()
        {
            return bookmarkDictionary_browser;
        }

        /// <summary>
        /// sets the dictionary of browser class
        /// </summary>
        /// <param name="Update_Dictionary"></param>
        public void Dictionary_Set(IDictionary<string, object> Update_Dictionary)
        {
            bookmarkDictionary_browser = Update_Dictionary;
        }

        /// <summary>
        /// This function opens a bookmark from favourite in a new tab
        /// </summary>
        /// <param name="fav_URL"></param>
        public void OpenfavPage(string fav_URL)
        {
            AddTabPage();
            url_textBox.Text = fav_URL;
            Get_Request(fav_URL);
        }

        /// <summary>
        /// opens the manage favourite window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addToListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manageFav = new ManageFavourites(bookmarkDictionary_browser, OpenfavPage, Dictionary_Set);
            manageFav.Show();
        }

        /// <summary>
        /// go back a page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void back_btn_Click(object sender, EventArgs e)
        {
            if (track_User_Histroy > 0)
            {
                string url = list_browser[--track_User_Histroy];
                url_textBox.Text = url;
                Get_Request(url);
                nextPage_btn.Enabled = true;
            }
            else
            {
                Get_Request(homePage);
                back_btn.Enabled = false;
                nextPage_btn.Enabled = true;
            }
        }

        /// <summary>
        /// go to the next page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextPage_btn_Click(object sender, EventArgs e)
        {
            if (track_User_Histroy < list_browser.Count-1)
            {
                Get_Request(list_browser[++track_User_Histroy]);
                back_btn.Enabled = true;
            }
            else
            {
                nextPage_btn.Enabled = false;
                back_btn.Enabled = true;
            }
        }

        /// <summary>
        /// this function opens the manage history window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageHistory = new ViewHistory(list_browser,OpenHistoryPage,setList_borwser);
            ManageHistory.Show();
        }

        /// <summary>
        /// returns browser class list
        /// </summary>
        /// <returns></returns>
        private List<string> getHistorylist()
        {
            return list_browser;
        }

        /// <summary>
        /// update the list of browser class
        /// </summary>
        /// <param name="setHistroyList"></param>
        private void setList_borwser(List<string> setHistroyList )
        {
            list_browser = setHistroyList;
            int historyCount = list_browser.Count;
            string currentURLInList = list_browser[historyCount - 1];
            track_User_Histroy = list_browser.IndexOf(currentURLInList);
        }

        /// <summary>
        /// opens the history url in a new tab
        /// </summary>
        /// <param name="fav_URL"></param>
        public void OpenHistoryPage(string fav_URL)
        {
            AddTabPage();
            url_textBox.Text = fav_URL;
            Get_Request(fav_URL);
        }
        
        /// <summary>
        /// the dictionary, list are initilized when the browser loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HW_Browser_Load(object sender, EventArgs e)
        {
            if (File.Exists("home.txt") && File.Exists("bookmark.json") && File.Exists("history.json"))
            {
                homePage = File.ReadAllText("home.txt");
                url_textBox.Text = homePage;

                Get_Request(homePage);

                string bookmarksFromFile = File.ReadAllText("bookmark.json");

                //deserilization of content from json file 
                bookmarkDictionary_browser = JsonConvert.DeserializeObject<Dictionary<string, object>>(bookmarksFromFile);

                string historyFromFile = File.ReadAllText("history.json");

                list_browser = JsonConvert.DeserializeObject<List<string>>(historyFromFile);
            }
            else
            {
                File.Create("home.txt");
                File.Create("bookmark.json");
                File.Create("history.json");
            }
            
            
        }

        /// <summary>
        /// history and favourites are written to their respectuve files through json serialization when browser is closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HW_Browser_FormClosing(object sender, FormClosingEventArgs e)
        {
            bookmarkDictionary_browser = Dictionary_Get();
            if (bookmarkDictionary_browser == null)
            {
                string result = JsonConvert.SerializeObject(bookmarkDictionary_browser);
                File.WriteAllText("bookmark.json", result);
            }
            else
            {
                try
                {
                    string result = JsonConvert.SerializeObject(bookmarkDictionary_browser);
                    File.WriteAllText("bookmark.json", result);
                }
                catch (ArgumentException exception)
                {

                    //throw exception;
                    Console.WriteLine("error on line 303");
                }
            }
            list_browser = getHistorylist();
            if (list_browser == null)
            {
                string result = JsonConvert.SerializeObject(list_browser);
                File.WriteAllText("history.json", result);
            }
            else
            {
                try
                {
                    string result = JsonConvert.SerializeObject(list_browser);
                    File.WriteAllText("history.json", result);
                }
                catch (ArgumentException exception)
                {

                    //throw exception;
                    Console.WriteLine("error on line 303");
                }
            }
            MessageBox.Show("Goodbye!");
        }

        /// <summary>
        /// This function tells information about the web browser
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This web browser is made by Roshan Sureen!" +
                            "It sends an httpRequest and displays the httpResponse from the server, Also handles the httpResponse messages.");
        }

        /// <summary>
        /// This function is used to exit from WinForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
