namespace Main
{
    partial class WaitDialogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_prompt = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_prompt
            // 
            this.lbl_prompt.Location = new System.Drawing.Point(12, 9);
            this.lbl_prompt.Name = "lbl_prompt";
            this.lbl_prompt.Size = new System.Drawing.Size(246, 34);
            this.lbl_prompt.TabIndex = 0;
            this.lbl_prompt.Text = "EDIT LABEL";
            this.lbl_prompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_prompt.Click += new System.EventHandler(this.label1_Click);
            this.lbl_prompt.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.lbl_prompt_ControlAdded);
            this.lbl_prompt.Validated += new System.EventHandler(this.lbl_prompt_Validated);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(95, 46);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 1;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // WaitDialogForm
            // 
            this.AcceptButton = this.btn_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 81);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.lbl_prompt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "WaitDialogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.WaitDialogForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lbl_prompt;
        private System.Windows.Forms.Button btn_OK;
    }
}