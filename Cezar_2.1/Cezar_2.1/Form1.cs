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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                if (comboBox2.SelectedIndex == 0 || comboBox2.SelectedIndex == 1)
                {
                    Form2 f = new Form2();

                    if (comboBox2.SelectedIndex == 0)
                    {
                        f.NUM = 1; f.alf = 26;
                        f.ShowDialog();

                    }
                    else if (comboBox2.SelectedIndex == 1)
                    {
                        f.NUM = 2; f.alf = 33;
                        f.ShowDialog();

                    }
                }
                else if (comboBox2.SelectedIndex == 2)
                {
                    Form3 h = new Form3();
                    h.NUM = 3;
                    h.ShowDialog();
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                if (comboBox2.SelectedIndex == 0 || comboBox2.SelectedIndex == 1)
                {
                    Form4 f = new Form4();

                    if (comboBox2.SelectedIndex == 0)
                    {
                        f.NUM = 1; f.alf = 26;
                        f.ShowDialog();

                    }
                    else if (comboBox2.SelectedIndex == 1)
                    {
                        f.NUM = 2; f.alf = 33;
                        f.ShowDialog();
                    }
                }
                else if (comboBox2.SelectedIndex == 2)
                {
                    Form5 h = new Form5();
                    h.NUM = 3;
                    h.ShowDialog();
                }
            }
        }
    }
}
