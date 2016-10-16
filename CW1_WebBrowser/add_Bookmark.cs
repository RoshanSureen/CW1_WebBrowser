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
        public string currentURL { get; set; }
        public add_Bookmark(string url_BK)
        {
            InitializeComponent();
            currentURL = url_BK;
            Initialize_URL_Field();
        }

        private void cancelBokmark_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Initialize_URL_Field()
        {
            url_bookmark.Text = currentURL;


        }
    }
}
