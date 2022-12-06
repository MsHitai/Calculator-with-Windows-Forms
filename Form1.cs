using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCalculator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);


            switch (comboBox1.Text)
            {
                case "+":
                    textBox3.Text = Convert.ToString(a + b);
                    break;
                case "-":
                    textBox3.Text = Convert.ToString(a - b);
                    break;
                case "*":
                    textBox3.Text = Convert.ToString(a * b);
                    break;
                case "/":
                    if (b == 0)
                    {
                        MessageBox.Show("На ноль делить нельзя!");
                    }
                    else
                    {
                        textBox3.Text = Convert.ToString(a / b);

                    }
                    break;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            comboBox1.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Text = "(" + textBox1.Text + " " + comboBox1.Text + " " + textBox2.Text + ")";
            textBox5.Text = textBox1.Text + " " + textBox2.Text + " " + comboBox1.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double c = Convert.ToDouble(textBox1.Text);
            if (c > 0)
            {
                double d = Math.Sqrt(c);
                textBox3.Text = Convert.ToString(d);
            }
            else
            {
                MessageBox.Show("Число должно быть больше нуля!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string stringValue = textBox1.Text.Trim().ToString();
            string stringPercentage = textBox2.Text.Trim().ToString();

            if (!string.IsNullOrEmpty(stringPercentage) && !string.IsNullOrEmpty(stringValue))
            {
                int intPercentage = 0;
                double doubleValue = 0.0;

                if ((int.TryParse(stringPercentage, out intPercentage) && Double.TryParse(stringValue, out doubleValue)))
                {
                    double doubleResult = (doubleValue * intPercentage) / 100;
                    textBox3.Text = doubleResult.ToString("#,#00.0000");
                }
                else
                {
                    MessageBox.Show("Значения должны быть больше нуля.");
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите оба значения для этой операции.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double a1, b1, c1;
            a1 = Convert.ToDouble(textBox1.Text);
            b1 = Convert.ToDouble(textBox2.Text);

            c1 = Math.Pow(a1, b1);
            textBox3.Text = Convert.ToString(c1);
        }
    }
}
