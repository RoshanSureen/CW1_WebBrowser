using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW1_WebBrowser
{
    public partial class HW_Browser : Form
    {
        public HW_Browser()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This web browser is made by Roshan Sureen!");
        }

        private void search_Btn_Click(object sender, EventArgs e)
        {
            
            
        }

        async void Get_Request(string url)
        {
            using (HttpClient client = new HttpClient())
            {

                using (HttpResponseMessage res = await client.GetAsync(url))
                {
                    using (HttpContent content = res.Content)
                    {
                        string webContent = await content.ReadAsStringAsync();
                        richTextBox.Text = webContent;
                    }
                }
            }
        }
    }
}
