﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeaWar
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        { 
            MessageBox.Show(tbName.Text+", добро пожаловать!");
            FormGame frm; /*Переход с первой формы на вторую*/
            frm = new FormGame();
            frm.ShowDialog();
            frm.Dispose();
            this.Hide();
          
        }

        private void FormStart_Load(object sender, EventArgs e)
        {

        }

        private void TbName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
