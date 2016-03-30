namespace Main
{
    partial class UserVerifier_CS
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
            this.label1 = new System.Windows.Forms.Label();
            this.tBox_Verify = new System.Windows.Forms.TextBox();
            this.btn_Verify = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Change = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Verification:";
            // 
            // tBox_Verify
            // 
            this.tBox_Verify.Location = new System.Drawing.Point(108, 15);
            this.tBox_Verify.Name = "tBox_Verify";
            this.tBox_Verify.Size = new System.Drawing.Size(175, 20);
            this.tBox_Verify.TabIndex = 1;
            // 
            // btn_Verify
            // 
            this.btn_Verify.Location = new System.Drawing.Point(108, 41);
            this.btn_Verify.Name = "btn_Verify";
            this.btn_Verify.Size = new System.Drawing.Size(75, 23);
            this.btn_Verify.TabIndex = 2;
            this.btn_Verify.Text = "Verify";
            this.btn_Verify.UseVisualStyleBackColor = true;
            this.btn_Verify.Click += new System.EventHandler(this.btn_Verify_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(190, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "wrong code.";
            this.label2.Visible = false;
            // 
            // btn_Change
            // 
            this.btn_Change.Location = new System.Drawing.Point(15, 41);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(75, 23);
            this.btn_Change.TabIndex = 4;
            this.btn_Change.Text = "Change";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Visible = false;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // Verify_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 67);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Verify);
            this.Controls.Add(this.tBox_Verify);
            this.Controls.Add(this.label1);
            this.Name = "Verify_User";
            this.Text = "Verify_User";
            this.Load += new System.EventHandler(this.Verify_User_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBox_Verify;
        private System.Windows.Forms.Button btn_Verify;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Change;
    }
}