using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("开始应用程序");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("已经结束应用程序");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 newform2 = new Form2();
            newform2.Show();
        }
    }
}
