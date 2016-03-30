using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using User__wpr;

namespace Movie_Search_Engine
{
    public class UserHandler_CS
    {
        private string host, cred;

        User__wpr.User_wpr checkUser = new User_wpr();
        private string usrname;
        private string pwd;

        private sbyte[] ToSbyte(char[] cTmp)
        {
            sbyte[] byteTmp = new sbyte[cTmp.Length];
            for (int i = 0; i < cTmp.Length; i++)
            {
                byteTmp[i] = Convert.ToSByte(cTmp[i]);
            }
            return byteTmp;
        }

        public void setFTP(string h, string c)
        {
            host = h;
            cred = c;
        }
        public UserHandler_CS()
        {
            host = @"ftp://192.168.10.105";
            cred = "public";
        }
        public bool checkUsername(string un)
        {
            Main.FTP downloadUser = new Main.FTP(host, cred, cred);
            downloadUser.download(string.Format("//Users//{0}.txt", un), string.Format(".//Database//User//{0}.txt", un));
            unsafe
            {
                fixed (sbyte* tmp_ = ToSbyte(un.ToCharArray()))
                {
                    try
                    {
                        checkUser.GetUser(tmp_);
                        usrname = un;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }

            if (usrname == un)
                return true;
            else
                return false;
        }

        public bool verifyPassword(string ps)// same din sa user name ang kulang
        {

            unsafe
            {
                fixed (sbyte* tmp_ = ToSbyte(ps.ToCharArray()))
                {
                    if (checkUser.checkPassword(tmp_))
                        return true;
                    else
                        return false;
                }
            }
        }

        public void GetData(string n, string p)
        {
            usrname = n;
            pwd = p;
        }

        public bool IsVerified()
        {
            unsafe
            {
                char a = Convert.ToChar(checkUser.verified[0]);
                if (a == '1')
                    return true;
                else
                    return false;
            }
        }

        public string VerificationCode()
        {
            unsafe
            {
                string tmp = "";
                for (int i = 0; checkUser.verification[i] != '\0'; i++)
                {
                    tmp += Convert.ToChar(checkUser.verification[i]);
                }
                return tmp;
            }
        }
    }
}
