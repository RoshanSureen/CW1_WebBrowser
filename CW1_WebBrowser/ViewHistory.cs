using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW1_WebBrowser
{
    public partial class ViewHistory : Form
    {
        /// <summary>
        /// A local list which is manipulated in this class
        /// </summary>
        private List<string> manageList;

        /// <summary>
        /// Delegates used for accesing function in browser.cs 
        /// </summary>
        private Action<string> actionlist;
        private Action<List<string>> hist_list;

        /// <summary>
        /// constructor for initilization
        /// </summary>
        /// <param name="listFromBrowser"></param>
        /// <param name="listAction"></param>
        /// <param name="list_hist"></param>
        public ViewHistory(List<string> listFromBrowser,Action<string> listAction,Action<List<string>> list_hist)
        {
            InitializeComponent();
            HistoryListBox.DataSource = new BindingSource(listFromBrowser,null);
            actionlist = listAction;
            hist_list = list_hist;
            manageList = listFromBrowser;
        }

        /// <summary>
        /// Opens the link in a new tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenHistoryLinkBtn_Click(object sender, EventArgs e)
        {
            string urlToLoad = HistoryListBox.SelectedItem.ToString();
            actionlist(urlToLoad);
        }

        /// <summary>
        /// Close the Manage history window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeViewHistory_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// deletes a link from history
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteBTn_Click(object sender, EventArgs e)
        {
            string urlToRemove = HistoryListBox.SelectedItem.ToString();
            if (manageList.Contains(urlToRemove))
            {
                manageList.Remove(urlToRemove);
            }
        }

        /// <summary>
        /// update history list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateBtn_Click(object sender, EventArgs e)
        {
            HistoryListBox.DataSource = new BindingSource(manageList,null);
        }

        /// <summary>
        /// send list back to browser.cs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewHistory_FormClosing(object sender, FormClosingEventArgs e)
        {
            hist_list(manageList);
        }
    }
}
