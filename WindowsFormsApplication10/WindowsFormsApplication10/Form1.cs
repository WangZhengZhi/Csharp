﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 newform2 = new Form2();
            newform2.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "https://www.baidu.com";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }
    }
}
