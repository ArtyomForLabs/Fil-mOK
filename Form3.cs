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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
                //string index = this.tableAdapterManager.UsersTableAdapter.IdbyLog(this.textBox1.Text, this.maskedTextBox1.Text).ToString();
                if (this.tableAdapterManager.UsersTableAdapter.IdbyLog(this.textBox1.Text, this.maskedTextBox1.Text) != null)
                {
                    MessageBox.Show("Добро пожаловать, " + this.textBox1.Text + "!", "Регистрация успешна!", MessageBoxButtons.OK);
                    Form2 f2 = this.Owner as Form2;
                    //f2.menuStrip1.Visible = false;
                    f2.Welcome.Text = this.textBox1.Text + " | В сети";
                    f2.Welcome.Location = new Point(0, 0);
                    // f2.Welcome.Visible = true;
                    f2.Welcome.Show();
                    f2.войтиToolStripMenuItem.Visible = false;
                    f2.label1.Enabled = true;
                    f2.label2.Enabled = true;

                   /* if (this.bDFilmDataSet.Users.FindById((int)this.tableAdapterManager.UsersTableAdapter.IdbyLog(this.textBox1.Text, this.maskedTextBox1.Text)).Key)
                    {
                        f2.редакторToolStripMenuItem.Visible = true;
                    }
                    else
                    {
                        f2.редакторToolStripMenuItem.Visible = false;
                    }
                    */

                    Close();
                }
                else
                {
                    MessageBox.Show("Неверное имя пользователя или пароль!", "Ошибка!", MessageBoxButtons.OK);
                }
           
            
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDFilmDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.bDFilmDataSet.Users);
        }
    }
}
