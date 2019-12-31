using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Lines[0]);
            int y = int.Parse(textBox1.Lines[1]);
            if (listBox1.Text == "+")
            {
                MessageBox.Show((x + y).ToString());
            }
            if (listBox1.SelectedItem.ToString() == "-")
            {
                MessageBox.Show((x - y).ToString());
            }
            if (listBox1.SelectedItem.ToString() == "/")
            {
                MessageBox.Show((x / y).ToString());
            }
            if (listBox1.SelectedItem.ToString() == "*")
            {
                MessageBox.Show((x * y).ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("+");
            listBox1.Items.Add("-");
            listBox1.Items.Add("/");
            listBox1.Items.Add("*");
        }
    }
}
