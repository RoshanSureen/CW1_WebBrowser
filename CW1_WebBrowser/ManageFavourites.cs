using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW1_WebBrowser
{
    public partial class ManageFavourites : Form
    {
        private Action<string> AddItems;

        public ManageFavourites(IDictionary<string,object> listBoxDictionary,Action<string> itemsAction )
        {
            InitializeComponent();
            favourites_listBox.DataSource = new BindingSource(listBoxDictionary,null);
            AddItems = itemsAction;
        }

        private void edit_Name_Click(object sender, EventArgs e)
        {
            
        }

        private void closeManageFav_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void favourites_listBox_Format(object sender, ListControlConvertEventArgs e)
        {
            KeyValuePair<string, object> item = (KeyValuePair<string, object>)e.ListItem;
            e.Value = string.Format("{0}\t({1})", item.Key, item.Value);
        }

        private void openURL_Click(object sender, EventArgs e)
        {
            string urlToLoad = favourites_listBox.SelectedItem.ToString();
            
            Regex regex = new Regex(@"(http|ftp|https):\/\/([\w_-]+(?:(?:\.[\w_-]+)+))([\w.,@?^=%&:/~+#-]*[\w@?^=%&/~+#-])?");
            Match match = regex.Match(urlToLoad);
            
            string urlToOpen = match.ToString();
            AddItems(urlToOpen);
            this.Close();
        }
    }
}
