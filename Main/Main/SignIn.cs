using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Movie_Search_Engine;
using User__wpr;

namespace Main
{
    public partial class SignInForm : Form
    {

        //User myUser = new User();// INSTANTIATE USER CLASS
        Movie_Search_Engine.UserHandler_CS myUser = new Movie_Search_Engine.UserHandler_CS();
        User__wpr.User_wpr CurrentUser = new User_wpr();
        public string username { get; set; }
        public bool loggedIn { get; set; }
        private string HOSTADRESS,credentials;
       public SignInForm(string Host)
        {
            InitializeComponent();
            HOSTADRESS = Host;
            credentials = "public";
            loggedIn = false;
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private sbyte[] ToSbyte(char[] cTmp)
        {
            sbyte[] byteTmp = new sbyte[cTmp.Length];
            for (int i = 0; i < cTmp.Length; i++)
            {
                byteTmp[i] = Convert.ToSByte(cTmp[i]);
            }
            return byteTmp;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MainHome f = new MainHome();
            
            f.Show();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
      
//********************************************************************************
        private void button1_Click(object sender, EventArgs e)
        {

            FTPControl downloadUser = new FTPControl(HOSTADRESS, credentials, credentials);
            downloadUser.DownloadUser(tbox_usrname.Text);

            if (myUser.checkUsername(tbox_usrname.Text))
            {
                
                if (myUser.verifyPassword(tbox_password.Text))
                {
                    //login ok
                    //check if user is verified
                    //   if not verified.. go to verify form
                    // else, log_in.
                    if (!myUser.IsVerified())
                    {
                        //////////////////////////////////////////////////////
                        string ver = myUser.VerificationCode();
                        UserVerifier_CS Current = new UserVerifier_CS(ver);
                        Current.ShowDialog();
                        if (Current.Verified)
                        {
                            User_wpr EditCurrent = new User_wpr();
                            Database_wpr.Database_wpr deleteOne = new Database_wpr.Database_wpr();
                            unsafe
                            {
                                fixed (sbyte* tmp_ = ToSbyte(tbox_usrname.Text.ToCharArray()))
                                {
                                    EditCurrent.GetUser(tmp_);
                                }
                                EditCurrent.verified[0] = Convert.ToSByte('1');

                                fixed (sbyte* tmp_ = ToSbyte(tbox_usrname.Text.ToCharArray()))
                                {
                                    if (deleteOne.DeleteUser(tmp_))
                                    {
                                        EditCurrent.SaveUser();
                                        FTPControl uploadNewUser = new FTPControl(HOSTADRESS, credentials, credentials);
                                        uploadNewUser.UploadUser(tbox_usrname.Text);

                                    }
                                }

                            }
                            MessageBox.Show("Login Success");
                            loggedIn = true;
                            username = tbox_usrname.Text;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("User Not verified");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Login Success");
                        loggedIn = true;
                        username = tbox_usrname.Text;
                        this.Close();
                    }
                    

                }
                else
                {
                    MessageBox.Show("Username or password is invalid!");
                    tbox_password.Text = tbox_usrname.Text = "";
                }

            }
            else
            {
                MessageBox.Show("Username or password is invalid!");
                tbox_password.Text = tbox_usrname.Text = "";
            }
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MainHome f1 = new MainHome();
            this.Hide();
            f1.Show();
        }

        
    }
}
