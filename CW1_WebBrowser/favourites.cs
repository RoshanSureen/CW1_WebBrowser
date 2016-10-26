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
    public partial class favourites : Form
    {
        public favourites()
        {
            InitializeComponent();
        }

        private void cancel_favForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
