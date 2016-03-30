using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SignUPForm;

namespace Main
{
 public partial class MainHome : Form
    {
     bool loggedIn;
     string username;
        private string HOSTADRESS, Credentials;
        FTPControl ftp;
        
        public MainHome()
        {
            InitializeComponent();
            AnimateTransparacy();
            HOSTADRESS = @"ftp://192.168.10.105/";
            Credentials = "public";
            ftp = new FTPControl(HOSTADRESS, Credentials, Credentials);
            loggedIn = false;
            SettingsChanger getsettings = new SettingsChanger();
            HOSTADRESS = getsettings.HOSTADRESS;
            getsettings.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (loggedIn)
            {
                SyncMovie();
                SearchForm sf = new SearchForm();
                sf.Show();
                this.Hide();
                sf.FormClosed += (a, b) => this.Show();
            }
            else
            {
                MessageBox.Show("please log in first");
                SignInForm si = new SignInForm(HOSTADRESS);
                si.ShowDialog();
                if (si.loggedIn)
                {
                    loggedIn = si.loggedIn;
                    username = si.username;
                    SyncMovie();
                    SearchForm sf = new SearchForm();
                    sf.Show();
                    this.Hide();
                    sf.FormClosed += (a, b) => this.Show();
                }
              
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SignupForm sif = new SignupForm(HOSTADRESS);
            this.Hide();
            sif.Show();
            sif.FormClosed += (a, b) => this.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SignInForm si = new SignInForm(HOSTADRESS);
            si.FormClosed += (a, b) => this.Show();
            this.Hide();
            si.Show();
            loggedIn = si.loggedIn;
            if (loggedIn)
            {
                username = si.username;
            }

        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AnimateTransparacy()
        {
            NewFormTImer.Enabled = true;
            NewFormTImer.Start();
            this.Opacity = .10;
            this.Show();
        }

        private void NewFormTImer_Tick_1(object sender, EventArgs e)
        {
            NewFormTImer.Interval = 10;
            if (this.Opacity < 1)
            {
                this.Opacity += 0.015;
            }
            else
            {
                NewFormTImer.Enabled = false;
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClosingTimer.Start();
        }

        private void ClosingTimer_Tick(object sender, EventArgs e)
        {
            NewFormTImer.Interval = 10;
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.015;
            }
            else
            {
                NewFormTImer.Enabled = false;
            }
        }

        private void btn_AddEdit_Click(object sender, EventArgs e)
        {
           
        }

        private void ftpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adressToolStripMenuItem.Text = HOSTADRESS;
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WaitDialogForm prompt = new WaitDialogForm();
            prompt.changePromt("Testing FTP Please wait...");
            
            ftp.Process.ProcessDone += new FTPEventsHandler.DoProcess(prompt.EnableButton);
            ftp.Process.ProcessDone += new FTPEventsHandler.DoProcess(prompt.DialogDone);
            prompt.process.Initialized += new WaitDialogForm.WaitEvent.DoProcess(ftp.TestFTPServer);
            prompt.ShowDialog();
            
        }
        private void SyncMovie()
        {
            WaitDialogForm prompt = new WaitDialogForm();

            prompt.Shown += (a, b) => prompt.changePromt("Syncing Movie Please wait...");

            ftp.Process.ProcessDone += new FTPEventsHandler.DoProcess(prompt.EnableButton);
            ftp.Process.ProcessDone += new FTPEventsHandler.DoProcess(prompt.DialogDone);
            //prompt.process.Initialized += new WaitDialogForm.WaitEvent.DoProcess(ftp.SyncMovie);
            prompt.lbl_prompt.TextChanged += (a, b) => ftp.SyncMovie();
            prompt.ShowDialog();
        }
        private void syncMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SyncMovie();
        }

        private void setHostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserVerifier_CS UseAsChangeHost = new UserVerifier_CS();
            UseAsChangeHost.ShowDialog();
            HOSTADRESS = UseAsChangeHost.newHOSTADRESS;
            UseAsChangeHost.Dispose();
            ftp = new FTPControl(HOSTADRESS, Credentials, Credentials);
            SettingsChanger getsettings = new SettingsChanger();
            getsettings.HOSTADRESS = HOSTADRESS;
            getsettings.Save();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserVerifier_CS veriadmin = new UserVerifier_CS("admin");
            veriadmin.changeLabel = "enter password";
            veriadmin.ShowDialog();
            if (veriadmin.Verified)
            {
                this.Hide();
                Add_Movie_Form.Add_Movie_Form addMovie = new Add_Movie_Form.Add_Movie_Form(HOSTADRESS);
                addMovie.Show();
                addMovie.FormClosed += (a, b) => this.Show();
            }
        }
    }
}

