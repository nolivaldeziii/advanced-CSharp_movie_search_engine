namespace Add_Movie_Form
{
    partial class Add_Movie_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Movie_Form));
            this.PicBox_Poster = new System.Windows.Forms.PictureBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.tBox_Title = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.label_Genre = new System.Windows.Forms.Label();
            this.tBox_Genre = new System.Windows.Forms.TextBox();
            this.label_CommaInfo = new System.Windows.Forms.Label();
            this.label_Writer = new System.Windows.Forms.Label();
            this.tBox_Writer = new System.Windows.Forms.TextBox();
            this.label_sActor = new System.Windows.Forms.Label();
            this.tBox_sActor = new System.Windows.Forms.TextBox();
            this.label_Actor = new System.Windows.Forms.Label();
            this.tBox_Actors = new System.Windows.Forms.TextBox();
            this.label_Prequel = new System.Windows.Forms.Label();
            this.label_Sequel = new System.Windows.Forms.Label();
            this.label_Runtime = new System.Windows.Forms.Label();
            this.label_Descriptions = new System.Windows.Forms.Label();
            this.tBox_Prequel = new System.Windows.Forms.TextBox();
            this.tBox_Sequel = new System.Windows.Forms.TextBox();
            this.tBox_Runtime = new System.Windows.Forms.TextBox();
            this.tBox_Descriptions = new System.Windows.Forms.TextBox();
            this.label_Country = new System.Windows.Forms.Label();
            this.tBox_Country = new System.Windows.Forms.TextBox();
            this.label_Language = new System.Windows.Forms.Label();
            this.tBox_Language = new System.Windows.Forms.TextBox();
            this.tBox_Directors = new System.Windows.Forms.TextBox();
            this.label_Directors = new System.Windows.Forms.Label();
            this.tBox_Tags = new System.Windows.Forms.TextBox();
            this.label_Tags = new System.Windows.Forms.Label();
            this.tBox_ReleaseDate = new System.Windows.Forms.TextBox();
            this.label_ReleaseDate = new System.Windows.Forms.Label();
            this.openPictureDB = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Poster)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBox_Poster
            // 
            this.PicBox_Poster.Image = ((System.Drawing.Image)(resources.GetObject("PicBox_Poster.Image")));
            this.PicBox_Poster.InitialImage = ((System.Drawing.Image)(resources.GetObject("PicBox_Poster.InitialImage")));
            this.PicBox_Poster.Location = new System.Drawing.Point(12, 12);
            this.PicBox_Poster.Name = "PicBox_Poster";
            this.PicBox_Poster.Size = new System.Drawing.Size(215, 245);
            this.PicBox_Poster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBox_Poster.TabIndex = 0;
            this.PicBox_Poster.TabStop = false;
            this.PicBox_Poster.Click += new System.EventHandler(this.PicBox_Poster_Click);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Location = new System.Drawing.Point(278, 12);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(33, 13);
            this.label_Title.TabIndex = 1;
            this.label_Title.Text = "Title: ";
            // 
            // tBox_Title
            // 
            this.tBox_Title.Location = new System.Drawing.Point(330, 12);
            this.tBox_Title.Name = "tBox_Title";
            this.tBox_Title.Size = new System.Drawing.Size(387, 20);
            this.tBox_Title.TabIndex = 1;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(186, 327);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 17;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(24, 327);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 15;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(105, 327);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 16;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // label_Genre
            // 
            this.label_Genre.AutoSize = true;
            this.label_Genre.Location = new System.Drawing.Point(265, 38);
            this.label_Genre.Name = "label_Genre";
            this.label_Genre.Size = new System.Drawing.Size(46, 13);
            this.label_Genre.TabIndex = 7;
            this.label_Genre.Text = "Genre*: ";
            // 
            // tBox_Genre
            // 
            this.tBox_Genre.Location = new System.Drawing.Point(330, 35);
            this.tBox_Genre.Name = "tBox_Genre";
            this.tBox_Genre.Size = new System.Drawing.Size(387, 20);
            this.tBox_Genre.TabIndex = 2;
            // 
            // label_CommaInfo
            // 
            this.label_CommaInfo.AutoSize = true;
            this.label_CommaInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CommaInfo.Location = new System.Drawing.Point(598, 353);
            this.label_CommaInfo.Name = "label_CommaInfo";
            this.label_CommaInfo.Size = new System.Drawing.Size(119, 13);
            this.label_CommaInfo.TabIndex = 9;
            this.label_CommaInfo.Text = "(*separated by commas)";
            // 
            // label_Writer
            // 
            this.label_Writer.AutoSize = true;
            this.label_Writer.Location = new System.Drawing.Point(261, 64);
            this.label_Writer.Name = "label_Writer";
            this.label_Writer.Size = new System.Drawing.Size(50, 13);
            this.label_Writer.TabIndex = 10;
            this.label_Writer.Text = "Writers*: ";
            // 
            // tBox_Writer
            // 
            this.tBox_Writer.Location = new System.Drawing.Point(330, 61);
            this.tBox_Writer.Name = "tBox_Writer";
            this.tBox_Writer.Size = new System.Drawing.Size(387, 20);
            this.tBox_Writer.TabIndex = 3;
            // 
            // label_sActor
            // 
            this.label_sActor.AutoSize = true;
            this.label_sActor.Location = new System.Drawing.Point(258, 142);
            this.label_sActor.Name = "label_sActor";
            this.label_sActor.Size = new System.Drawing.Size(53, 13);
            this.label_sActor.TabIndex = 12;
            this.label_sActor.Text = "Starring*: ";
            // 
            // tBox_sActor
            // 
            this.tBox_sActor.Location = new System.Drawing.Point(330, 139);
            this.tBox_sActor.Name = "tBox_sActor";
            this.tBox_sActor.Size = new System.Drawing.Size(387, 20);
            this.tBox_sActor.TabIndex = 6;
            // 
            // label_Actor
            // 
            this.label_Actor.AutoSize = true;
            this.label_Actor.Location = new System.Drawing.Point(264, 168);
            this.label_Actor.Name = "label_Actor";
            this.label_Actor.Size = new System.Drawing.Size(47, 13);
            this.label_Actor.TabIndex = 14;
            this.label_Actor.Text = "Actors*: ";
            // 
            // tBox_Actors
            // 
            this.tBox_Actors.Location = new System.Drawing.Point(330, 165);
            this.tBox_Actors.Name = "tBox_Actors";
            this.tBox_Actors.Size = new System.Drawing.Size(387, 20);
            this.tBox_Actors.TabIndex = 7;
            // 
            // label_Prequel
            // 
            this.label_Prequel.AutoSize = true;
            this.label_Prequel.Enabled = false;
            this.label_Prequel.Location = new System.Drawing.Point(270, 461);
            this.label_Prequel.Name = "label_Prequel";
            this.label_Prequel.Size = new System.Drawing.Size(49, 13);
            this.label_Prequel.TabIndex = 16;
            this.label_Prequel.Text = "Prequel: ";
            this.label_Prequel.Visible = false;
            // 
            // label_Sequel
            // 
            this.label_Sequel.AutoSize = true;
            this.label_Sequel.Enabled = false;
            this.label_Sequel.Location = new System.Drawing.Point(273, 487);
            this.label_Sequel.Name = "label_Sequel";
            this.label_Sequel.Size = new System.Drawing.Size(46, 13);
            this.label_Sequel.TabIndex = 17;
            this.label_Sequel.Text = "Sequel: ";
            this.label_Sequel.Visible = false;
            // 
            // label_Runtime
            // 
            this.label_Runtime.AutoSize = true;
            this.label_Runtime.Location = new System.Drawing.Point(259, 220);
            this.label_Runtime.Name = "label_Runtime";
            this.label_Runtime.Size = new System.Drawing.Size(52, 13);
            this.label_Runtime.TabIndex = 18;
            this.label_Runtime.Text = "Runtime: ";
            // 
            // label_Descriptions
            // 
            this.label_Descriptions.AutoSize = true;
            this.label_Descriptions.Location = new System.Drawing.Point(243, 246);
            this.label_Descriptions.Name = "label_Descriptions";
            this.label_Descriptions.Size = new System.Drawing.Size(68, 13);
            this.label_Descriptions.TabIndex = 19;
            this.label_Descriptions.Text = "Descriptions:";
            // 
            // tBox_Prequel
            // 
            this.tBox_Prequel.Enabled = false;
            this.tBox_Prequel.Location = new System.Drawing.Point(338, 458);
            this.tBox_Prequel.Name = "tBox_Prequel";
            this.tBox_Prequel.Size = new System.Drawing.Size(14, 20);
            this.tBox_Prequel.TabIndex = 8;
            this.tBox_Prequel.Visible = false;
            // 
            // tBox_Sequel
            // 
            this.tBox_Sequel.Enabled = false;
            this.tBox_Sequel.Location = new System.Drawing.Point(338, 484);
            this.tBox_Sequel.Name = "tBox_Sequel";
            this.tBox_Sequel.Size = new System.Drawing.Size(14, 20);
            this.tBox_Sequel.TabIndex = 9;
            this.tBox_Sequel.Visible = false;
            // 
            // tBox_Runtime
            // 
            this.tBox_Runtime.Location = new System.Drawing.Point(330, 217);
            this.tBox_Runtime.Name = "tBox_Runtime";
            this.tBox_Runtime.Size = new System.Drawing.Size(89, 20);
            this.tBox_Runtime.TabIndex = 11;
            // 
            // tBox_Descriptions
            // 
            this.tBox_Descriptions.Location = new System.Drawing.Point(330, 247);
            this.tBox_Descriptions.Multiline = true;
            this.tBox_Descriptions.Name = "tBox_Descriptions";
            this.tBox_Descriptions.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tBox_Descriptions.Size = new System.Drawing.Size(387, 103);
            this.tBox_Descriptions.TabIndex = 14;
            // 
            // label_Country
            // 
            this.label_Country.AutoSize = true;
            this.label_Country.Location = new System.Drawing.Point(425, 220);
            this.label_Country.Name = "label_Country";
            this.label_Country.Size = new System.Drawing.Size(49, 13);
            this.label_Country.TabIndex = 24;
            this.label_Country.Text = "Country: ";
            // 
            // tBox_Country
            // 
            this.tBox_Country.Location = new System.Drawing.Point(471, 217);
            this.tBox_Country.Name = "tBox_Country";
            this.tBox_Country.Size = new System.Drawing.Size(89, 20);
            this.tBox_Country.TabIndex = 12;
            // 
            // label_Language
            // 
            this.label_Language.AutoSize = true;
            this.label_Language.Location = new System.Drawing.Point(566, 220);
            this.label_Language.Name = "label_Language";
            this.label_Language.Size = new System.Drawing.Size(61, 13);
            this.label_Language.TabIndex = 26;
            this.label_Language.Text = "Language: ";
            // 
            // tBox_Language
            // 
            this.tBox_Language.Location = new System.Drawing.Point(628, 217);
            this.tBox_Language.Name = "tBox_Language";
            this.tBox_Language.Size = new System.Drawing.Size(89, 20);
            this.tBox_Language.TabIndex = 13;
            // 
            // tBox_Directors
            // 
            this.tBox_Directors.Location = new System.Drawing.Point(330, 87);
            this.tBox_Directors.Name = "tBox_Directors";
            this.tBox_Directors.Size = new System.Drawing.Size(387, 20);
            this.tBox_Directors.TabIndex = 4;
            // 
            // label_Directors
            // 
            this.label_Directors.AutoSize = true;
            this.label_Directors.Location = new System.Drawing.Point(252, 90);
            this.label_Directors.Name = "label_Directors";
            this.label_Directors.Size = new System.Drawing.Size(59, 13);
            this.label_Directors.TabIndex = 28;
            this.label_Directors.Text = "Directors*: ";
            // 
            // tBox_Tags
            // 
            this.tBox_Tags.Location = new System.Drawing.Point(330, 113);
            this.tBox_Tags.Name = "tBox_Tags";
            this.tBox_Tags.Size = new System.Drawing.Size(387, 20);
            this.tBox_Tags.TabIndex = 5;
            // 
            // label_Tags
            // 
            this.label_Tags.AutoSize = true;
            this.label_Tags.Location = new System.Drawing.Point(270, 116);
            this.label_Tags.Name = "label_Tags";
            this.label_Tags.Size = new System.Drawing.Size(41, 13);
            this.label_Tags.TabIndex = 30;
            this.label_Tags.Text = "Tags*: ";
            // 
            // tBox_ReleaseDate
            // 
            this.tBox_ReleaseDate.Location = new System.Drawing.Point(330, 191);
            this.tBox_ReleaseDate.Name = "tBox_ReleaseDate";
            this.tBox_ReleaseDate.Size = new System.Drawing.Size(387, 20);
            this.tBox_ReleaseDate.TabIndex = 10;
            // 
            // label_ReleaseDate
            // 
            this.label_ReleaseDate.AutoSize = true;
            this.label_ReleaseDate.Location = new System.Drawing.Point(233, 191);
            this.label_ReleaseDate.Name = "label_ReleaseDate";
            this.label_ReleaseDate.Size = new System.Drawing.Size(78, 13);
            this.label_ReleaseDate.TabIndex = 32;
            this.label_ReleaseDate.Text = "Release Date: ";
            // 
            // openPictureDB
            // 
            this.openPictureDB.FileName = "movie.jpg";
            // 
            // Add_Edit_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 381);
            this.Controls.Add(this.tBox_ReleaseDate);
            this.Controls.Add(this.label_ReleaseDate);
            this.Controls.Add(this.tBox_Tags);
            this.Controls.Add(this.label_Tags);
            this.Controls.Add(this.tBox_Directors);
            this.Controls.Add(this.label_Directors);
            this.Controls.Add(this.tBox_Language);
            this.Controls.Add(this.label_Language);
            this.Controls.Add(this.tBox_Country);
            this.Controls.Add(this.label_Country);
            this.Controls.Add(this.tBox_Descriptions);
            this.Controls.Add(this.tBox_Runtime);
            this.Controls.Add(this.tBox_Sequel);
            this.Controls.Add(this.tBox_Prequel);
            this.Controls.Add(this.label_Descriptions);
            this.Controls.Add(this.label_Runtime);
            this.Controls.Add(this.label_Sequel);
            this.Controls.Add(this.label_Prequel);
            this.Controls.Add(this.tBox_Actors);
            this.Controls.Add(this.label_Actor);
            this.Controls.Add(this.tBox_sActor);
            this.Controls.Add(this.label_sActor);
            this.Controls.Add(this.tBox_Writer);
            this.Controls.Add(this.label_Writer);
            this.Controls.Add(this.label_CommaInfo);
            this.Controls.Add(this.tBox_Genre);
            this.Controls.Add(this.label_Genre);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.tBox_Title);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.PicBox_Poster);
            this.Name = "Add_Edit_Form";
            this.Text = "Add/Edit Movie";
            this.Load += new System.EventHandler(this.Add_Edit_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Poster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBox_Poster;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.TextBox tBox_Title;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label label_Genre;
        private System.Windows.Forms.TextBox tBox_Genre;
        private System.Windows.Forms.Label label_CommaInfo;
        private System.Windows.Forms.Label label_Writer;
        private System.Windows.Forms.TextBox tBox_Writer;
        private System.Windows.Forms.Label label_sActor;
        private System.Windows.Forms.TextBox tBox_sActor;
        private System.Windows.Forms.Label label_Actor;
        private System.Windows.Forms.TextBox tBox_Actors;
        private System.Windows.Forms.Label label_Prequel;
        private System.Windows.Forms.Label label_Sequel;
        private System.Windows.Forms.Label label_Runtime;
        private System.Windows.Forms.Label label_Descriptions;
        private System.Windows.Forms.TextBox tBox_Prequel;
        private System.Windows.Forms.TextBox tBox_Sequel;
        private System.Windows.Forms.TextBox tBox_Runtime;
        private System.Windows.Forms.TextBox tBox_Descriptions;
        private System.Windows.Forms.Label label_Country;
        private System.Windows.Forms.TextBox tBox_Country;
        private System.Windows.Forms.Label label_Language;
        private System.Windows.Forms.TextBox tBox_Language;
        private System.Windows.Forms.TextBox tBox_Directors;
        private System.Windows.Forms.Label label_Directors;
        private System.Windows.Forms.TextBox tBox_Tags;
        private System.Windows.Forms.Label label_Tags;
        private System.Windows.Forms.TextBox tBox_ReleaseDate;
        private System.Windows.Forms.Label label_ReleaseDate;
        private System.Windows.Forms.OpenFileDialog openPictureDB;
    }
}

