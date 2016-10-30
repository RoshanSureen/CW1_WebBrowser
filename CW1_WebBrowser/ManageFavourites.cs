using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CW1_WebBrowser
{
    public partial class ManageFavourites : Form
    {
        /// <summary>
        /// Delegates
        /// </summary>
        private Action<string> AddItems;
        private Action<IDictionary<string, object>> actionDict;

        /// <summary>
        /// local dictionary is manupilated in this class
        /// </summary>
        private IDictionary<string, object> manageDictionary;

        /// <summary>
        /// Constructor for Manage favourites
        /// </summary>
        /// <param name="listBoxDictionary"></param>
        /// <param name="itemsAction"></param>
        /// <param name="DictAction"></param>
        public ManageFavourites(IDictionary<string,object> listBoxDictionary,Action<string> itemsAction
            , Action<IDictionary<string, object>> DictAction)
        {
            InitializeComponent();
            favourites_listBox.DataSource = new BindingSource(listBoxDictionary,null);
            AddItems = itemsAction;
            actionDict = DictAction;
            manageDictionary = listBoxDictionary;
        }

        /// <summary>
        /// modify the name associated with url
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void edit_Name_Click(object sender, EventArgs e)
        {
            nameLabel.Visible = true;
            editTxtBox.Visible = true;
            editTxtBox.Enabled = true;
            ConfirmChange.Visible = true;
            ConfirmChange.Enabled = true;
            
        }
        
        /// <summary>
        /// sets the value for the associated key
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfirmChange_Click(object sender, EventArgs e)
        {
            string selectedValue = favourites_listBox.SelectedItem.ToString();

            Regex regex = new Regex(@"(http|ftp|https):\/\/([\w_-]+(?:(?:\.[\w_-]+)+))([\w.,@?^=%&:/~+#-]*[\w@?^=%&/~+#-])?");
            Match match = regex.Match(selectedValue);
            string urlToEdit = match.ToString();

            if (manageDictionary.ContainsKey(urlToEdit))
            {
                manageDictionary[urlToEdit] = editTxtBox.Text;
            }
        }

        /// <summary>
        /// update the favourites list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void update_Click(object sender, EventArgs e)
        {
            favourites_listBox.DataSource = new BindingSource(manageDictionary,null);
            nameLabel.Visible = false;
            editTxtBox.Visible = false;
            editTxtBox.Enabled = false;
            ConfirmChange.Visible = false;
            ConfirmChange.Enabled = false;
        }

        /// <summary>
        /// Format how favourites are displayed on the listBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void favourites_listBox_Format(object sender, ListControlConvertEventArgs e)
        {
            KeyValuePair<string, object> item = (KeyValuePair<string, object>)e.ListItem;
            e.Value = string.Format("{0}\t({1})", item.Key, item.Value);
        }

        /// <summary>
        /// open favourites url in a new tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openURL_Click(object sender, EventArgs e)
        {
            string urlToLoad = favourites_listBox.SelectedItem.ToString();
            
            Regex regex = new Regex(@"(http|ftp|https):\/\/([\w_-]+(?:(?:\.[\w_-]+)+))([\w.,@?^=%&:/~+#-]*[\w@?^=%&/~+#-])?");
            Match match = regex.Match(urlToLoad);
            
            string urlToOpen = match.ToString();
            AddItems(urlToOpen);
            this.Close();
        }
        
        /// <summary>
        /// Delete a bookmark from list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveFav_Click(object sender, EventArgs e)
        {
            string selectedValue = favourites_listBox.SelectedItem.ToString();

            Regex regex = new Regex(@"(http|ftp|https):\/\/([\w_-]+(?:(?:\.[\w_-]+)+))([\w.,@?^=%&:/~+#-]*[\w@?^=%&/~+#-])?");
            Match match = regex.Match(selectedValue);
            string urlToRemove = match.ToString();

            if (manageDictionary.ContainsKey(urlToRemove))
            {
                manageDictionary.Remove(urlToRemove);
            }
        }

        /// <summary>
        /// send the dictionary to browser.cs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManageFavourites_FormClosing(object sender, FormClosingEventArgs e)
        {
            actionDict(manageDictionary);
        }
    }
}
