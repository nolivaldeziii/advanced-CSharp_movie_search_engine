using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    
    class UserVerifier
    {
      
       private string usrname;
       private string pwd;       

        public bool checkUsername(string un)
        {
            if (usrname == un)
                return true;
            else
                return false;
        }

        public bool verifyPassword(string ps)
        {
            if (pwd == ps)
                return true;
            else
                return false;

        }

        public void GetData(string n, string p)
        {
            usrname = n;
            pwd = p;
        }
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainHome());
            //Application.Run(new SearchForm());
        }
    }


}
