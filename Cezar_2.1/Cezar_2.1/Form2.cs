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

namespace Cezar_2._1
{
    public partial class Form2 : Form
    {
        public int k; public int alf;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = Regex.Replace(textBox1.Text, @"[^0-9]+", "");
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
            string x = textBox1.Text; string y = textBox4.Text; string txt = textBox2.Text;
            if (textBox1.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Вы не ввели один из ключей", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                goto Lag;
            }
            else
            {
                int w = int.Parse(x);  int r = int.Parse(y);
                if (alf % w == 0)
                {
                    MessageBox.Show("Длина алфавита(" + alf + ") и А имеют общие делители. Пожалуйста выберите другое число А.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    goto Lab;
                }
                else
                {
                    Class1 c1 = new Class1(txt, w, r, k); c1.Alf(); c1.Shifr();
                    textBox3.Text += c1.txt2;
                }
            Lab:
                {

                }
            }
        Lag:
            {

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = Regex.Replace(textBox4.Text, @"[^0-9]+", "");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ключ - должен быть взимно простым с мощностью (длиной) выбранного алфавита(не иметь общих делителей кроме самих себя)!!! Пример: можность алфавита = 33 значит А не может быть равно 3, 11, 33 и т.д.. Может быть только целым и неотрицательным числом!", 
                "Info",
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ключ - может быть только целым и неотрицательным числом!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
