using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Cezar_2._0
{
    public partial class Form2 : Form
    {
        public int k;   
        public int NUM
        {
            set
            {
                k = value;
            }
        }
        public Form2()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        } 
        
        private void button1_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text; string txt = textBox2.Text;
            if (textBox1.Text == "")
            {
                MessageBox.Show("Вы не ввели ключ", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                goto Lab;
            }
            else
            {
                int lol = int.Parse(x);
                Class1 c1 = new Class1(txt, lol, k); c1.Alf(); c1.Shifr();
                textBox3.Text += c1.txt2;
            }
            Lab:
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = Regex.Replace(textBox1.Text, @"[^0-9]+", "");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ключ - количество сдвигов по алфавиту. Может быть только целым и неотрицательным числом!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
