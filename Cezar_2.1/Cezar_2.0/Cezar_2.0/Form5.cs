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
    public partial class Form5 : Form
    {
        public int k;
        public int NUM
        {
            set
            {
                k = value;
            }
        }
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text; string txt = textBox2.Text;
            string txt1 = textBox4.Text; int y = txt1.Length;
            if (textBox1.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Вы не ввели ключ или свой алфавит!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                goto Lab;
            }
            else
            {
                int lol = int.Parse(x);
                Class1 c1 = new Class1(lol, txt, k, txt1);
                c1.Alf(); c1.RasShifr();
                textBox3.Text += c1.txt4;
            }
        Lab:
            {

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = Regex.Replace(textBox4.Text, @"[^а-яА-Яa-zA-Z]+", "");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = Regex.Replace(textBox1.Text, @"[^0-9]+", "");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ключ - количество сдвигов по алфавиту. Может быть только целым и неотрицательным числом!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Пользовательский алфавит - ваш алфавит по которому будет происходить шифрование. Вводить буквы в одну строчку слитно!!!!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
