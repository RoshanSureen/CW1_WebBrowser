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
        public TabPage currentTabPage { get; set; }
        public TabPage tb;

        public RichTextBox curRichTextBox { get; set; }
        public RichTextBox newRich_TxtBox;

        public favourites fav;
        public ManageFavourites manageFav;

        public string url_Value;

        public IDictionary<string, object> bookmarkDictionary_fav;
        public IDictionary<string, object> bookmarkDictionary_browser;
        
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
                // the client will wait for the request to be completed and then store the response in object 'res'
                using (HttpResponseMessage res = await client.GetAsync(url))
                {
                    if (res.IsSuccessStatusCode)
                    {
                        using (HttpContent content = res.Content)
                        {
                            string webContent = await content.ReadAsStringAsync();

                            HtmlAgilityPack.HtmlDocument htmlDoc = new HtmlAgilityPack.HtmlDocument();
                            htmlDoc.OptionFixNestedTags = true;

                            htmlDoc.LoadHtml(webContent);

                            var tab_header = htmlDoc.DocumentNode.SelectSingleNode("//head/title");
                            string titleFromPage = WebUtility.HtmlDecode(tab_header.InnerText.Trim());
                            DisplayWebContent(webContent, titleFromPage);
                        }
                    }
                    else
                    {
                        try
                        {
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
        }
        

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
                            curRichTextBox = (RichTextBox) control;
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
            if (e.KeyChar == (char) ConsoleKey.Enter)
            {
                search_Btn_Click(null, null);
            }
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


        private void bookmarkThisPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fav = new favourites(url_textBox.Text);
            fav.Show();
        }


        public IDictionary<string, object> Dictionary_Get()
        {
            return bookmarkDictionary_browser;
        }


        //public void Dictionary_Set(IDictionary<string, object> Update_Dictionary)
        //{
        //    bookmarkDictionary_browser = bookmarkDictionary_browser.Concat(Update_Dictionary).ToDictionary(x => x.Key, x => x.Value);
        //}

        public void OpenfavPage(string fav_URL)
        {
            AddTabPage();
            url_textBox.Text = fav_URL;
            Get_Request(fav_URL);
        }


        private void addToListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manageFav = new ManageFavourites(bookmarkDictionary_browser, OpenfavPage);
            manageFav.Show();
        }


        private void HW_Browser_Load(object sender, EventArgs e)
        {
            if (File.Exists("home.txt"))
            {
                string homePage = File.ReadAllText("home.txt");
                url_textBox.Text = homePage;
                Get_Request(homePage);
            }
            else
            {
                File.Create("home.txt");
            }
            string bookmarksFromFile = File.ReadAllText("bookmark.json");
            bookmarkDictionary_browser = JsonConvert.DeserializeObject<Dictionary<string, object>>(bookmarksFromFile);
        }


        private void HW_Browser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bookmarkDictionary_fav == null)
            {
                bookmarkDictionary_fav = fav.GetDictionary();
            }
            
            bookmarkDictionary_browser = Dictionary_Get();
            if (bookmarkDictionary_browser == null)
            {
                string result = JsonConvert.SerializeObject(bookmarkDictionary_fav);
                File.WriteAllText("bookmark.json", result);
            }
            else
            {
                try
                {
                    var newDictionary = bookmarkDictionary_browser.Concat(bookmarkDictionary_fav)
                    .ToDictionary(x => x.Key, x => x.Value);
                    string result = JsonConvert.SerializeObject(newDictionary);
                    File.WriteAllText("bookmark.json", result);
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
