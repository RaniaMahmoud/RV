using System;
using static F_BaseN.Convert;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F_BaseN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Lines[0]);
            int N = int.Parse(textBox1.Lines[1]);
            Convert c = new Convert(N);
            c.radix = N;
            textBox2.Text += c.ForDc(num);
            textBox2.Text += Environment.NewLine;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Lines[0]);
            int N = int.Parse(textBox1.Lines[1]);
            Convert c = new Convert(N);
            c.radix = N;
            textBox2.Text += c.ToDc(textBox1.Lines[0]);
            textBox2.Text += Environment.NewLine;
        }
    }

}
