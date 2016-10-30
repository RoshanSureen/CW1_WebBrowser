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

        /// <summary>
        /// delegate
        /// </summary>
        private Action<IDictionary<string, object>> dictAction;

        /// <summary>
        /// dynamic object used as a dictionary
        /// </summary>
        public static dynamic bookmarkDetails = new ExpandoObject();
        IDictionary<string,object> dictionary = (IDictionary<string, object>)bookmarkDetails;
        
        /// <summary>
        /// constructor for favourites class
        /// </summary>
        /// <param name="url"></param>
        /// <param name="dict"></param>
        public favourites(string url, Action<IDictionary<string, object>> dict)
        {
            InitializeComponent();
            urlWebsite_txtBox.Text = url;
            dictAction = dict;
        }
        

        /// <summary>
        /// return the local dictionary
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, object> GetDictionary()
        {
            return dictionary;
        }

        /// <summary>
        /// passes the url and name to be added to the dictionary
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveBookamrkBtn_Click(object sender, EventArgs e)
        {
            string name1 = urlWebsite_txtBox.Text;
            string name2 = urlName_txtBox.Text;
            
            addBookmarkToFile(name1,name2);
            this.Close();
        }

        /// <summary>
        /// this function adds the url and name associated with it to dictionary
        /// </summary>
        /// <param name="urlToAdd"></param>
        /// <param name="urlNameToAdd"></param>
        private void addBookmarkToFile(string urlToAdd, string urlNameToAdd)
        {
            dictionary.Add(urlToAdd,urlNameToAdd);
        }

        /// <summary>
        /// closes the favourites form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancel_favForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// passes the dictionary to browser.cs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void favourites_FormClosing(object sender, FormClosingEventArgs e)
        {
            dictAction(dictionary);
        }
    }
}
