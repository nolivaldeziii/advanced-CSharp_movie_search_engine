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
    public partial class WaitDialogForm : Form
    {
        public class WaitEvent
        {
            public delegate void DoProcess();
            public event DoProcess Initialized;

            public void Done()
            {
                if (Initialized != null)
                {
                    Initialized();
                    EmptyDelegate();
                }
            }
            private void EmptyDelegate()
            {
                Initialized = null;
            }
        }
        public WaitEvent process = new WaitEvent();
        public WaitDialogForm(/*string prompt*/)
        {
            InitializeComponent();
            btn_OK.Enabled = false;
            this.Refresh();
            this.ControlBox = false;
            //process.Done();
            //this.btn_OK.Text = "Done";
            //this.ControlBox = false;
            //lbl_prompt.Text = prompt;
        }
        public void EnableButton()
        {
            this.btn_OK.Enabled = true;
        }
        public void changePromt(string prompt)
        {
            lbl_prompt.Text = prompt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void WaitDialogForm_Load(object sender, EventArgs e)
        {
            lbl_prompt.Refresh();
            process.Done();
        }
        public void DialogDone()
        {
            lbl_prompt.Text = "Done!";
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_prompt_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void lbl_prompt_Validated(object sender, EventArgs e)
        {
        }
    }
}
