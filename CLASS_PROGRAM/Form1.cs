using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLASS_PROGRAM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculation ob1 = new Calculation();
            ob1.a = 40;
            ob1.b = 50;
            ob1.display();
            textBox1.Text = ob1.res.ToString();
        }
    }
}
