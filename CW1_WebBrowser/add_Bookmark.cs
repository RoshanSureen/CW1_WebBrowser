﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Threading;

namespace CW1_WebBrowser
{
    public partial class add_Bookmark : Form
    {
        public add_Bookmark()
        {
            InitializeComponent();
            Initialize_URL_Field();

        }

        private void cancelBokmark_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Initialize_URL_Field()
        {
            HW_Browser hb = new HW_Browser();
               
        }
    }
}
