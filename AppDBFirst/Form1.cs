﻿using AppDBFirst.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDBFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Redresh();
        }

        private void Redresh()
        {
            var userService = new UserSerice();
            dataGridView1.DataSource = userService.GetAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Redresh();
        }
    }
}
