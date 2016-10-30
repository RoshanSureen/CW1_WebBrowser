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
        private List<string> manageList;
        private Action<string> actionlist;
        private Action<List<string>> hist_list;

        public ViewHistory(List<string> listFromBrowser,Action<string> listAction,Action<List<string>> list_hist)
        {
            InitializeComponent();
            HistoryListBox.DataSource = new BindingSource(listFromBrowser,null);
            actionlist = listAction;
            hist_list = list_hist;
            manageList = listFromBrowser;
        }

        private void OpenHistoryLinkBtn_Click(object sender, EventArgs e)
        {
            string urlToLoad = HistoryListBox.SelectedItem.ToString();
            actionlist(urlToLoad);
        }

        private void closeViewHistory_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteBTn_Click(object sender, EventArgs e)
        {
            string urlToRemove = HistoryListBox.SelectedItem.ToString();
            if (manageList.Contains(urlToRemove))
            {
                manageList.Remove(urlToRemove);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            HistoryListBox.DataSource = new BindingSource(manageList,null);
        }

        private void ViewHistory_FormClosing(object sender, FormClosingEventArgs e)
        {
            hist_list(manageList);
        }
    }
}
