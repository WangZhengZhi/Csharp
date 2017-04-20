using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            string datetime = string.Format("{0}:D", dt);
            
            button2.Text = datetime;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            string datetime = string.Format("{0}:f",dt);
           
            button1.Text = datetime;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            string datetime = string.Format("{0}:m", dt);

            button3.Text = string.Format("{0}:h",dt);

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            DateTime dt =  DateTime.Now;
            string datetime = String.Format("{0}:g",dt);
            




        }
    }
}
