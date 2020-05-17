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
    public partial class Form4 : Form
    {
        public int k;
        public int NUM
        {
            set
            {
                k = value;
            }
        }
        public Form4()
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
            if(textBox1.Text == "")
            {
                MessageBox.Show("Вы не ввели ключ", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                goto Lab;
            }
            else
            {
                int lol = int.Parse(x);
                Class1 c1 = new Class1(lol, txt, k); c1.Alf(); c1.RasShifr();
                textBox3.Text += c1.txt4;
            }
        Lab:
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = Regex.Replace(textBox1.Text, @"[^0-9]+", "");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ключ - количество сдвигов по алфавиту. Может быть только целым и неотрицательным числом!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
