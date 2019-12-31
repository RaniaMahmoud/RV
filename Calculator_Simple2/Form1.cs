using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Simple2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = int.Parse(textBox1.Lines[0]);
            int y = int.Parse(textBox2.Lines[0]);
            string n = GetLineFromCharIndex();
            if (n == "+")
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
        public int GetCharIndexFromPosition()
        {
            return listBox1.SelectedIndex;
        }
        public string  GetLineFromCharIndex()
        {
            int z = GetCharIndexFromPosition();
            return (listBox1.Items[z].ToString());
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            listBox1.Items.Add("+");
            listBox1.Items.Add("-");
            listBox1.Items.Add("/");
            listBox1.Items.Add("*");
        }
    }
}
