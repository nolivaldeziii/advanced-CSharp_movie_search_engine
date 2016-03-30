using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using SignUPForm;

namespace Main
{
 public partial class Home : Form
    {
        private string HOSTADRESS, Credentials;
        FTPControl ftp;
        public Home()
        {
            InitializeComponent();
            AnimateTransparacy();
            HOSTADRESS = @"ftp://192.168.10.105/";
            Credentials = "public";
            ftp = new FTPControl(HOSTADRESS, Credentials, Credentials);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm();
            
            sf.Show();
            this.Hide();
            
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
            SignIn si = new SignIn(HOSTADRESS);
            this.Hide();
            si.Show();

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
            this.Hide();
            Add_and_Edit_Movie_Form.Add_Edit_Form addMovie = new Add_and_Edit_Movie_Form.Add_Edit_Form(HOSTADRESS);
            addMovie.Show();
            addMovie.FormClosed += (a, b) => this.Show();
        }

        private void ftpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ftp.TestFTPServer();
            MessageBox.Show("Test Done");
        }

        private void syncMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ftp.SyncMovie();
            MessageBox.Show("Sync Done");
        }

        private void setHostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Verify_User UseAsChangeHost = new Verify_User();
            UseAsChangeHost.ShowDialog();
            HOSTADRESS = UseAsChangeHost.newHOSTADRESS;
            UseAsChangeHost.Dispose();
            ftp = new FTPControl(HOSTADRESS, Credentials, Credentials);
        }
    }
}

