using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int size = int.Parse(textBox1.Lines[0]);
            int num = int.Parse(textBox1.Lines[1]);
            Stack s = new Stack(size);
            int sum = 0, n;
            string str = null;
            while (num > 0)
            {
                n = num % 10;
                num /= 10;
                s.push(n);
            }
            int x=0;
            while (!s.Emptey()&& size>1)
            {
                x= s.pop();
                sum += x;
                str += x.ToString() + ",";
                --size;
            }
             x = s.pop();
            sum += x;
            str += x.ToString() + "";
            MessageBox.Show(str);
            MessageBox.Show(sum.ToString());
        }
    }
    class Stack
    {
        int size;
        int[] array;
        int top;
        public Stack(int s = 10)
        {
            size = s;
            array = new int[size];
            top = -1;
        }
        public void push(int item)
        {
            array[++top] = item;
        }
        public int pop()
        {
            return array[top--];
        }
        public bool Full()
        {
            return (top == size - 1);
        }
        public bool Emptey()
        {
            return (top == - 1);
        }
    }
}
