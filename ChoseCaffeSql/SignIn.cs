﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChoseCaffeSql
{
    public partial class SignIn : MyForm
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter Login");
            }else if (textBox2.Text == "")
            {
                MessageBox.Show("Enter Password");
            }
            else
            {
                MessageBox.Show("You are SignIn");
                this.Close();
            }
        }
    }
}
