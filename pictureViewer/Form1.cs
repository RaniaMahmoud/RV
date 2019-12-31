using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pictureViewer
{
    public partial class Form1 : Form
    {
        int cont = 0;
        OpenFileDialog op;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            op = new OpenFileDialog();
            op.Multiselect = true;
            op.ShowDialog();
            foreach (string s in op.FileNames)
            {
                listBox1.Items.Add(s);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                Application.Exit();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                timer1.Interval = 5000;
                timer1.Tick += Timer1_Tick;
                timer1.Start();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = listBox1.Items[cont++].ToString();
            label1.Text = Path.GetFileName(listBox1.Items[cont++].ToString());
            if (cont >= listBox1.Items.Count)
                cont = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(listBox1.SelectedItem.ToString());
        }
    }
}
