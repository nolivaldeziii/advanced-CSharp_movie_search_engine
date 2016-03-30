using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class SettingsChanger
    {
        public string HOSTADRESS { get; set; }

        public SettingsChanger()
        {
            if(System.IO.File.Exists("settings.ini"))
            {
                System.IO.StreamReader readSet = new System.IO.StreamReader("settings.ini");
                HOSTADRESS = readSet.ReadLine();
                readSet.Close();
            }
        }
        public void Save()
        {
            System.IO.StreamWriter writeSet = new System.IO.StreamWriter("settings.ini", false);
            writeSet.WriteLine(HOSTADRESS);
            writeSet.Close();
        }

        ~SettingsChanger()
        {
            System.IO.StreamWriter writeSet = new System.IO.StreamWriter("settings.ini", false);
            writeSet.WriteLine(HOSTADRESS);
            writeSet.Close();
        }
    }
}
