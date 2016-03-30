using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using MovieClass_wpr;

namespace Add_and_Edit_Movie_Form
{
    public partial class Add_Edit_Form : Form
    {
        private string HOSTADRESS,credentials;

        public Add_Edit_Form(string host)
        {
            InitializeComponent();
            if (!Directory.Exists(".\\Database\\Movie\\"))
            {
                Directory.CreateDirectory(".\\Database\\Movie\\");
            }
            if (!Directory.Exists(".\\Database\\Movie\\Posters"))
            {
                Directory.CreateDirectory(".\\Database\\Movie\\Posters");
            }
            HOSTADRESS = host;
            credentials = "public";
        }

        MovieCSclass NewMovie = new MovieCSclass();
        bool good = true;
        //Check For Missing Data
        private bool MissingInfo()
        {
            if (tBox_Title.Text == "")
                return true;
            if(tBox_Actors.Text == "")
                return true;
            if(tBox_Country.Text == "")
                return true;
            if(tBox_Descriptions.Text == "")
                return true;
            if(tBox_Genre.Text == "")
                return true;
            //if(tBox_Prequel.Text == "")
            //    return true;
            if(tBox_Runtime.Text == "")
                return true;
            if(tBox_sActor.Text == "")
                return true;
            //if(tBox_Sequel.Text == "")
            //    return true;
            if(tBox_Writer.Text == "")
                return true;

            return false;
        }
        //save to class
        private void GatherData()
        {
            NewMovie.Actors =  tBox_Actors.Text;
            NewMovie.Descriptions = tBox_Descriptions.Text;
            NewMovie.Directors = tBox_Directors.Text;
            NewMovie.Genre = tBox_Genre.Text;
            NewMovie.StarActors = tBox_sActor.Text;
            NewMovie.Tags = tBox_Title.Text;
            NewMovie.Title = tBox_Title.Text;
            NewMovie.Writers = tBox_Writer.Text;
            NewMovie.Prequel = tBox_Prequel.Text;
            NewMovie.Sequel = tBox_Sequel.Text;
            NewMovie.ReleaseDate = tBox_ReleaseDate.Text;
            try
            {
                good = true;
                NewMovie.Runtime = Convert.ToInt32(tBox_Runtime.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Enter an integer on Runtime");
                good = false;
            }
            NewMovie.Language = tBox_Language.Text;
            NewMovie.Country = tBox_Country.Text;

            NewMovie.ImageLocation = PicBox_Poster.ImageLocation;
        }
        //save data c++ dll wrapper
        private void Save()
        {
            
            unsafe
            {
                MovieClass_wpr.Movie_wpr AddMovie = new MovieClass_wpr.Movie_wpr();

                char[] ctmp =  NewMovie.Title.ToCharArray();
                
                fixed (sbyte* _tmp = ToSbyte(ctmp))//start saving to text file
                {
                    AddMovie.GetTitle(_tmp);
                }
                ctmp = NewMovie.Genre.ToCharArray();
                fixed(sbyte* _tmp=ToSbyte(ctmp))
                {
                    AddMovie.GetGenre(_tmp);
                }
                ctmp = NewMovie.Tags.ToCharArray();
                fixed (sbyte* _tmp = ToSbyte(ctmp))
                {
                    AddMovie.GetTags(_tmp);
                }
                ctmp = NewMovie.Writers.ToCharArray();
                fixed (sbyte* _tmp = ToSbyte(ctmp))
                {
                    AddMovie.GetWriters(_tmp);
                }
                ctmp = NewMovie.StarActors.ToCharArray();
                fixed (sbyte* _tmp = ToSbyte(ctmp))
                {
                    AddMovie.GetS_Actors(_tmp);
                }
                ctmp = NewMovie.Actors.ToCharArray();
                fixed (sbyte* _tmp = ToSbyte(ctmp))
                {
                    AddMovie.GetActors(_tmp);
                }
                ctmp = NewMovie.Directors.ToCharArray();
                fixed (sbyte* _tmp = ToSbyte(ctmp))
                {
                    AddMovie.GetDirectors(_tmp);
                }
                AddMovie.GetRating(0);
                AddMovie.GetRuntime(NewMovie.Runtime);
                ctmp = NewMovie.Country.ToCharArray();
                fixed (sbyte* _tmp = ToSbyte(ctmp))
                {
                    AddMovie.GetCountry(_tmp);
                }
                ctmp = NewMovie.Language.ToCharArray();
                fixed (sbyte* _tmp = ToSbyte(ctmp))
                {
                    AddMovie.GetLanguage(_tmp);
                }
                ctmp = NewMovie.ReleaseDate.ToCharArray();
                fixed (sbyte* _tmp = ToSbyte(ctmp))
                {
                    AddMovie.GetReleaseDate(_tmp);
                }
                ctmp = NewMovie.Descriptions.ToCharArray();
                fixed (sbyte* _tmp = ToSbyte(ctmp))
                {
                    AddMovie.GetDescriptions(_tmp);
                }

                ctmp = string.Format(".\\Database\\Movie\\{0}.txt", NewMovie.Title).ToCharArray();
                fixed (sbyte* _tmp = ToSbyte(ctmp))
                {
                    AddMovie.Save(_tmp);
                }
                

                PicBox_Poster.Image.Save(string.Format(".\\Database\\Movie\\Posters\\{0}.jpg", tBox_Title.Text), PicBox_Poster.Image.RawFormat);

                Main.FTPControl uploadMovie = new Main.FTPControl(HOSTADRESS, credentials, credentials);
                uploadMovie.UploadMovie(NewMovie.Title);
            }
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

        private void Add_Edit_Form_Load(object sender, EventArgs e)
        {
            PicBox_Poster.InitialImage = PicBox_Poster.InitialImage;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
           
            if (MissingInfo())
            {
                if (tBox_Title.Text != "")
                {
                    if(File.Exists(string.Format(".\\Database\\Movie\\{0}.txt",tBox_Title.Text)))
                    {
                        good = false;
                        MessageBox.Show("Movie Already Exist");
                    }
                    else if (MessageBox.Show(this, "Some info is missing\nContinue?", "Warning", MessageBoxButtons.YesNo)
                        == DialogResult.Yes)
                    {
                        GatherData();
                        if (good)
                            Save();// Savedata, call c++ dll wrapper
                    }
                    else
                    {
                        good = false;
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter a movie name");
                    good = false;
                }

            }
            else
            {
                GatherData();
                if (File.Exists(string.Format(".\\Database\\Movie\\{0}.txt", tBox_Title.Text)))
                {
                    good = false;
                    MessageBox.Show("Movie Already Exist");
                }
                if (good)
                    Save();//save data, call c++ dll wrapper
            }
            if (good)
                if (MessageBox.Show(this, "Movie Saved, Continue?", "Message", MessageBoxButtons.YesNo)
                    == DialogResult.No)
                {
                    this.Close();
                }
                else
                {
                    CleanForm();
                }
            
        }

       
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            CleanForm();
        }
        private void CleanForm()
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
            }
            PicBox_Poster.Image = PicBox_Poster.InitialImage;
        }

        private void PicBox_Poster_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsImage())
            {
                PicBox_Poster.Image = Clipboard.GetImage();
            }
            else
            {
                //System.Drawing.Image.FromFile(Clipboard.GetData(DataFormats.
            }
        }
    }	



}
