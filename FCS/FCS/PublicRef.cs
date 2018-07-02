using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCS
{
  public  class PublicRef
    {

        public string GetServerHost() {
            object regvalue = Registry.CurrentUser.OpenSubKey(@"FCSKey").GetValue("ServerHost");
            return regvalue.ToString(); ;
         

        }

        public string GetDatabaseName()
        {
            object regvalue = Registry.CurrentUser.OpenSubKey(@"FCSKey").GetValue("DatabaseName");
            return regvalue.ToString();
        }

        public string GetUserName()
        {
            object regvalue = Registry.CurrentUser.OpenSubKey(@"FCSKey").GetValue("UserName");
            return regvalue.ToString();
        }

        public string GetPassword()
        {
            object regvalue = Registry.CurrentUser.OpenSubKey(@"FCSKey").GetValue("Password");
            return regvalue.ToString();
        }

        //public void ForInputSecurity(string strApp, TextBox s)
        //{
        //    var list = new List<string>();
        //    list.Add("Select ");
        //    list.Add(" * ");
        //    list.Add(" From ");
        //    list.Add(" Where ");
        //    list.Add(" null ");
        //    list.Add(" / ");
        //    list.Add(" ' ");
        //    list.Add(@" \ ");
        //    list.Add(" < ");
        //    list.Add(" > ");

        //    if (list.Contains(strApp, StringComparer.OrdinalIgnoreCase))
        //    {
        //        s.Clear();
        //    }
        //}
        //private string f { get; set; }

        //public string getBoxSearch(string boxcode) {
        //    f = boxcode;
        //    return f;
        //}

        //public string setBoxSearch(string boxcode)
        //{
        //    f = boxcode;
        //    return f;
        //}


    }
}
