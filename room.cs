using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fil_mOK
{
    public partial class room : Form
    {
        public string time = null;
        public List<String> listb = new List<string>();
        public Button[] bt;
        public room()
        {
            InitializeComponent();
        }

        public room(object sender, EventArgs e)
        {
            InitializeComponent();
            time = (sender as Label).Text;
        }

        public void room_Load(object sender, EventArgs e)
        {
            this.sessionTableAdapter.Fill(this.bDFilmDataSet.Session);
            int x = 30, y = 30,w=30,h=30,dx=5,dy=5;
            bt = new Button[9];
                for (int k = 1, i=0; k <= 3; k++)
                {
                    for (int j = 1; j <= 3; j++)
                    {
                        bt[i] = new Button();
                        bt[i].Text = (i + 1).ToString();
                        bt[i].Tag = i + 1;
                        bt[i].Width = w;
                        bt[i].Height = h;
                        bt[i].Click+=new EventHandler(addseat);
                        bt[i].Location = new Point(j * x + dx, k * y + dy);
                        this.Controls.Add(bt[i++]);
                    }
                }            
            BDFilmDataSet.SessionDataTable dt = this.sessionTableAdapter.GetDataByTime(time);
            for (int i = 0; i < 9; i++)
            {
                    if (dt.FindByTimeSeat(TimeSpan.Parse(time),Int32.Parse(bt[i].Tag.ToString()))!=null)
                    {
                        bt[i].Enabled = false;
                        bt[i].BackColor = Color.FromName("ActiveCaption");
                    }
            }
        }

        private void sessionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sessionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDFilmDataSet);

        }
        
        public void addseat(object sender, EventArgs e)
        {
            listb.Add((sender as Button).Tag.ToString());
            (sender as Button).BackColor = Color.FromName("ActiveCaption");
            (sender as Button).Click -= new EventHandler(addseat);
            (sender as Button).Click += new EventHandler(removeseat);
        }

        public void removeseat(object sender, EventArgs e)
        {

            listb.Remove((sender as Button).Tag.ToString());
            (sender as Button).BackColor = Color.FromName("Control");
            (sender as Button).Click -= new EventHandler(removeseat);
            (sender as Button).Click += new EventHandler(addseat);
        }

        public void button1_Click(object sender, EventArgs e)
        {
            bool flag = false;
            foreach(String b in listb)
            {
                if (b != null)
                {
                    this.sessionTableAdapter.Insert(TimeSpan.Parse(time), Int32.Parse(b));
                    this.sessionTableAdapter.Fill(this.bDFilmDataSet.Session);
                    flag = true;
                }
            }
            if (flag)
            {
                MessageBox.Show("Успешно!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Вы не выбрали место в зале!");
            }
        }
    }
}
