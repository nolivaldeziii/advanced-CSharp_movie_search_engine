using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Threading;

using User__wpr;
using Email_CS;

namespace SignUPForm
{
    public partial class SignupForm : Form
    {
        private string HOSTADRESS, credentials;
        private Register Sign = new Register();
        public SignupForm(string Host)
        {
            InitializeComponent();
            HOSTADRESS = Host;
            credentials = "public";
        }
        public SignupForm()
        {
            InitializeComponent();
        }

        int verificationCode;
        bool good = true;

        private sbyte[] ToSbyte(char[] cTmp)
        {
            sbyte[] byteTmp = new sbyte[cTmp.Length];
            for (int i = 0; i < cTmp.Length; i++)
            {
                byteTmp[i] = Convert.ToSByte(cTmp[i]);
            }
            return byteTmp;
        }

        private bool verifyCharacter(char c)
        {
            return ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || c == '_' || c == '.' || (c >= '0' && c <= '9')); // iccheck kung within range ba ung character.
        }
        private bool isValidEmail(string Emailaddress)
        {
            int atremove = -1;
            int dotremove = -1;
            int length = Emailaddress.Length;// get length of email address
            for (int i = 0; i < length; i++)
            {
                if (Emailaddress[i] == '@') // hnahanap ung position ng @ sign
                    atremove = i;
                else if (Emailaddress[i] == '.')// same sa @
                    dotremove = i;
                else if (!verifyCharacter(Emailaddress[i]))
                    return false;

            }
            if (atremove == -1 || dotremove == -1) // pag walang @ or . hindi valid email address
                return false;
            if (atremove > dotremove)//
                return false;

            return !(dotremove >= (length - 1));
        }

        User__wpr.User_wpr newUser = new User__wpr.User_wpr();
        private void SaveToDLL()
        {
            unsafe
            {
                char[] ctmp = UserName.Text.ToCharArray();
                fixed (sbyte* _tmp = ToSbyte(ctmp))//start saving to text file
                {
                    newUser.GetUsername(_tmp);
                }

                ctmp = password.Text.ToCharArray();
                fixed (sbyte* _tmp = ToSbyte(ctmp))//start saving to text file
                {
                    newUser.GetPassword(_tmp);
                }

                ctmp = (FirstName.Text + " " + LastName.Text).ToCharArray();
                fixed (sbyte* _tmp = ToSbyte(ctmp))//start saving to text file
                {
                    newUser.GetFullname(_tmp);
                }

                ctmp = email.Text.ToCharArray();
                fixed (sbyte* _tmp = ToSbyte(ctmp))//start saving to text file
                {
                    newUser.GetEmail(_tmp);
                }
                Random rnd = new Random();
                verificationCode = rnd.Next(100000, 999990);
                ctmp = verificationCode.ToString().ToCharArray();
                fixed (sbyte* _tmp = ToSbyte(ctmp))//start saving to text file
                {
                    newUser.GetVerification(_tmp);
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label_verify.Visible = true;
            if(!isValidEmail(email.Text))
            {
                MessageBox.Show("email not valid");
            }
            else if (password.Text == confirm.Text)
            {
                SaveToDLL();
                label_verify.Visible = true;
                try
                {
                    newUser.SaveUser();
                    UploadUser();
                    
                    //SendEmail();
                    
                }
                catch (NullReferenceException)
                {
                    good = false;
                    MessageBox.Show("[NRE] Error please try again");
                }
                catch(Exception)
                {
                    good = false;
                    MessageBox.Show("Problem saving your account:\nExisting User");
                }
                if (good)
                {
                    UserName.Clear();
                    FirstName.Clear();
                    LastName.Clear();
                    password.Clear();
                    confirm.Clear();
                    email.Clear();
                    if (MessageBox.Show("Register Completed!", "Movie", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        this.Close();
                    }
                }

            }
            else
            {
                MessageBox.Show("Password did not match!", "Error", MessageBoxButtons.OK);
                password.Clear();
                confirm.Clear();
            }
        }
        private void  UploadUser()
        {
            Main.MovieSearchEngineFTP uploadNewUser = new Main.MovieSearchEngineFTP(HOSTADRESS, credentials, credentials);
            try
            {
                uploadNewUser.UploadUser(UserName.Text);
            }
            catch(Exception f)
            {
                if (MessageBox.Show("Cannot Upload User\n Retry? if no, You cannot use your account beside this computer\n"+f.Message, "Upload Fail", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    UploadUser();
                }
            }
        }
        private void FirstName_TextChanged(object sender, EventArgs e)
        {
            Sign.First=FirstName.Text;  
        }
        private void LastName_TextChanged(object sender, EventArgs e)
        {
            Sign.Last = LastName.Text;
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {
            Sign.User = UserName.Text;
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            Sign.Pass = password.Text;
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            Sign.Mail = email.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // babalik sa unang form
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SendEmail()
        {
            try
            {
                Email_CS.Email send = new Email();
                send.getName(FirstName.Text);
                send.getTarget(email.Text);
                if (!send.VerifyEmail(verificationCode.ToString()))
                {
                    label_verify.Text = "Email Not sent";
                }
            }
            catch
            {
                if (MessageBox.Show("Send Email Failed\nRetry?", "Email Problem"
                    , MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SendEmail();
                }
            }
        }

        private void SignupForm_Load(object sender, EventArgs e)
        {

        }
    }
}
