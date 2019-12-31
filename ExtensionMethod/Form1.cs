using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtensionMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int t1 = textBox1.Lines.Length;
            int[] A = new int[t1];
            int t2 = textBox2.Lines.Length;
            int[] B = new int[t2];
            for (int i = 0; i < t1; i++)
            {
                A[i] = int.Parse(textBox1.Lines[i]);
            }
            for (int i = 0; i < t2; i++)
            {
                B[i] = int.Parse(textBox2.Lines[i]);
            }
            textBox3.Lines = A.Add(B);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int t1 = textBox1.Lines.Length;
            string[] A = new string[t1];
            int t2 = textBox2.Lines.Length;
            string [] B = new string[t2];
            for (int i = 0; i < t1; i++)
            {
                A[i] = textBox1.Lines[i];
            }
            for (int i = 0; i < t2; i++)
            {
                B[i] = textBox2.Lines[i];
            }
            textBox3.Lines = A.Add(B);
        }
    }
    public static class myExtension
    {
        public static string[] Add(this int[]A,int[]B)
        {
            string[] S;
            if (A.Length > B.Length)
            {
                S = new string[A.Length];
                for (int i = 0; i < A.Length; i++)
                {
                    S[i] = A[i].ToString();
                }
                for (int i = 0; i < B.Length; i++)
                {
                    S[i] = (A[i] + B[i]).ToString();
                }
            }
            else
            {
                S = new string[B.Length];
                for (int i = 0; i < B.Length; i++)
                {
                    S[i] = B[i].ToString();
                }
                for (int i = 0; i < A.Length; i++)
                {
                    S[i] = (A[i] + B[i]).ToString();
                }
            }

            return S;
        }
        public static string[] Add(this string[] A, string[] B)
        {
            string[] S= null;
            if (A.Length > B.Length)
            {
                S = new string[A.Length];
                for (int i = 0; i < A.Length; i++)
                {
                    S[i] = A[i].ToString();
                }
                for (int i = 0; i < B.Length; i++)
                {
                    S[i] += B[i];
                }
            }
            else
            {
                S = new string[B.Length];
                for (int i = 0; i < B.Length; i++)
                {
                    S[i] = B[i].ToString();
                }
                for (int i = 0; i < A.Length; i++)
                {
                    S[i] += A[i];
                }
            }

            return S;
        }
    }
}
