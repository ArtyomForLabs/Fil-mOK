﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDFilmDataSet.Film". При необходимости она может быть перемещена или удалена.
            this.filmTableAdapter.Fill(this.bDFilmDataSet.Film);
            
        }
        private void filmBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.filmBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDFilmDataSet);

        }
    }
}
