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
    public partial class ManageFavourites : Form
    {
        public ManageFavourites(IDictionary<string,object> listBoxDictionary)
        {
            InitializeComponent();
            favourites_listBox.DataSource = new BindingSource(listBoxDictionary,null);
            
        }

        private void InitilizeListBox(IDictionary<string, object> listDictionary)
        {
           
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
            e.Value = string.Format("{0}({1})", item.Key, item.Value);
        }
    }
}
