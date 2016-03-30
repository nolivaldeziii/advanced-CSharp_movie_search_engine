using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class UserVerifier_CS : Form
    {
        private string _secret;
        private bool verified = false;
        public bool Verified { get { return verified; } }

        public UserVerifier_CS(string secret)
        {
            InitializeComponent();
            _secret = secret;
        }
        public UserVerifier_CS()
        {
            InitializeComponent();
            this.Name = "Change Host Adress";
            btn_Change.Visible = true;
            btn_Verify.Visible = false;
            btn_Change.Location = btn_Verify.Location;
            label1.Text = "Enter Host: ";
        }
        private void btn_Verify_Click(object sender, EventArgs e)
        {
            if (_secret == tBox_Verify.Text)
            {
                verified = true;
                this.Close();
            }
            else
            {
                label2.Visible = true;
            }
        }
        public string changeLabel { get; set; }
        private void Verify_User_Load(object sender, EventArgs e)
        {
            label1.Text = changeLabel;
        }
        public string newHOSTADRESS { get; set; }
        private void btn_Change_Click(object sender, EventArgs e)
        {
            newHOSTADRESS = tBox_Verify.Text;
            this.Close();
        }
    }
}
