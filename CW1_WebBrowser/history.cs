using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW1_WebBrowser
{
    public class history
    {
        public static List<String> historyList = new List<string>();

        //public static int trackHistory;

        
        public static void addToList(string historyURL)
        {
            if (historyList.Contains(historyURL))
            {
                Console.WriteLine("Its there!");
            }
            else
            {
                historyList.Add(historyURL);
            }
        }

        public static List<string> GetList()
        {
            return historyList;
        }
    }
}
