using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW1_WebBrowser
{
    class HomePage
    {
        public string url_HomePage { get; set; }
        public string name_HomePage { get; set; }

        public override string ToString()
        {
            return string.Format("URL: {0} \nAge: {1}", url_HomePage, name_HomePage);
        }
    }
}
