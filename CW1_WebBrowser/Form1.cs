using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Threading;

namespace CW1_WebBrowser
{
    public partial class HW_Browser : Form
    {
        

        public HW_Browser()
        {
            InitializeComponent();
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

        /// <summary>
        /// This function tells information about the web browser
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This web browser is made by Roshan Sureen!" +
                            "It seds an httpRequest and displays the httpResponse from the server, Also handles the httpResponse messages.");
        }

        /// <summary>
        /// This function runs when the search btn is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void search_Btn_Click(object sender, EventArgs e)
        {
            Thread url_Thread = new Thread(new ThreadStart(NavigateToPage));
            url_Thread.Start();
            url_Thread.Abort();
        }

        /// <summary>
        /// This is the core function that will perform request and response calls
        /// </summary>
        private void NavigateToPage()
        {
            // the url typed by user in the textbox is stored in var web_URL
            string web_URL = url_textBox.Text;

            // function call
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
                    // try and catch is used to display httpResponse error messages
                    try
                    {
                        using (HttpContent content = res.Content)
                        {
                            string webContent = await content.ReadAsStringAsync();
                            richTextBox.Text = webContent;

                        }
                    }
                    catch (Exception e)
                    {
                        richTextBox.Text = e.Message;

                    }
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
                NavigateToPage();
            }
        }

        private void home_Btn_Click(object sender, EventArgs e)
        {
            string homePage = url_textBox.Text;
            File.WriteAllText("home.txt",homePage);
            MessageBox.Show("Your home page is set to this website!");
        }

        private void HW_Browser_Activated(object sender, EventArgs e)
        {
            string homePage = File.ReadAllText("home.txt");
            Get_Request(homePage);


        }
    }
}
