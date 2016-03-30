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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainHome f1 = new MainHome();
            this.Hide();
            f1.Show();
        }

        private void SearchForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            //NotifyBallon.Visible = true;
            //NotifyBallon.ShowBalloonTip(5, "hello", "hello ulit", ToolTipIcon.None);
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MessageBox.Show(dataGridView1[0, e.RowIndex].Value.ToString());
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
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void SearchStart()
        {
            Database_wpr.Database_wpr search = new Database_wpr.Database_wpr();
            unsafe
            {
                char[] ctmp = tbox_Search.Text.ToCharArray();

                fixed (sbyte* _tmp = ToSbyte(ctmp))//start saving to text file
                {
                    sbyte** store;
                    System.Collections.Queue returns = new System.Collections.Queue();
                    store = search.Search(_tmp);
                    string tmp = "";
                    for (int i = 0; store[i] != null; i++)
                    {
                        tmp = "";
                        try
                        {
                            for (int j = 0; store[i][j] != -51; j++)
                            {
                                tmp += Convert.ToChar((store[i][j]));
                            }
                        }
                        catch (AccessViolationException) { }
                        returns.Enqueue(tmp);
                    }
                    //int k = 0;
                    //while (returns.Peek() != null)
                    {
                        dataGridView1.Rows.Clear();
                        object[] searchResult = returns.ToArray();
                        for (int i = 0; i < searchResult.Length; i++)
                        {
                            dataGridView1.Rows.Add(searchResult[i]);
                        }
                        //dataGridView1.Rows[++i].
                    }
                }
            }
        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string movieTitle = dataGridView1[0, e.RowIndex].Value.ToString();
            Add_Movie_Form.Add_Movie_Form viewMovie = new Add_Movie_Form.Add_Movie_Form(null);
            viewMovie.SetData(movieTitle);
            viewMovie.ShowDialog();
        }

        private void tbox_Search_TextChanged(object sender, EventArgs e)
        {
            if (tbox_Search.Text != "")
            {
                SearchStart();
            }
        }

    }
}
