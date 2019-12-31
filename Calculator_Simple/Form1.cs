using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Simple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calc c = new Calc(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox3.Text = c.Add().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calc c = new Calc(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox3.Text = c.Sub().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calc c = new Calc(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox3.Text = c.Div().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Calc c = new Calc(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox3.Text = c.Mult().ToString();
        }
    }
    public class Calc
    {
        int x;
        int y;
        public Calc(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int Add()
        {
            return x + y;
        }
        public int Sub()
        {
            return x - y;
        }
        public int Mult()
        {
            return x * y;
        }
        public int Div()
        {
            return x / y;
        }
    }
}
