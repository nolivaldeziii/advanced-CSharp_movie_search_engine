using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Main
{
    class RegistrationHandler
    {
        private string FName; //First Name
        private string LName; //Last Name
        private string UName; //Username
        private string password;
        private string email;
        private int domain;
        //private FileStream write;
        public RegistrationHandler()
        {
            FName = " ";
            LName = " ";
            UName = " ";
            password = " ";
            email = " ";
            domain = 0;
        }
        public string First
        {
            get
            {
                return FName;
            }
            set
            {
                FName = value;
            }
        }
        public string Last
        {
            get
            {
                return LName;
            }
            set
            {
                LName = value;
            }
        }
        public string User
        {
            get
            {
                return UName;
            }
            set
            {
                UName = value;
            }
        }
        public string Pass
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        public string Mail
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public int Dom
        {
            get
            {
                return domain;
            }
            set
            {
                domain = value;
            }
        }
        //public void OpenFile()
        //{

        //    write = new FileStream("" + UName.ToString() + ".txt", FileMode.Create);
        //}

        //public void WriteData(StreamWriter sw)
        //{
        //    sw.WriteLine(LName+ " " +
        //                FName + " " +
        //                UName + " " +
        //                password + " " +
        //                email +" ");
        //}

        //public void CloseFile()
        //{
        //    write.Close();
        //}

        public bool Comparedata(string u, string p) // u = username p= password
        {
            LoadData();
            //method(int) to find the idnum sa array, return index
            //method to compare idnum
            //then sa loob ng last method compare password 


            return true;
        }

        public void LoadData()
        {
            //read the txt file and store in array yung ID and password lang
        }
    }
}
