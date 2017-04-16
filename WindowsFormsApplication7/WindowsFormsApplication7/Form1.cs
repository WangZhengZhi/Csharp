using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 newform2 = new Form2();
            newform2.Show();
            newform2.MdiParent = this;
            Form3 newform3 = new Form3();
            newform3.Show();
            newform3.MdiParent = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public Form MdiParent { get; set; }

        private void Form1_Layout(object sender, LayoutEventArgs e)
        {

        }
    }
}
