using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotNet_lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //first
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Clear();

            string buf = "";
            for (decimal i = numericUpDown1.Minimum; i < numericUpDown1.Value + 1; i++)
            {
                buf += i + " ";
            }
            textBox1.Text = buf;
        }

        //second
        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = comboBox1.SelectedItem.ToString();
        }

        //third
        private void btnPlus_Click(object sender, EventArgs e)
        {
            double r1, r2;
            if (double.TryParse(textBox4.Text, out r1) && double.TryParse(textBox5.Text, out r2))
                textBox6.Text = (r1 + r2).ToString();
            else textBox6.Text = "Error";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            double r1, r2;
            if (double.TryParse(textBox4.Text, out r1) && double.TryParse(textBox5.Text, out r2))
                textBox6.Text = (r1 - r2).ToString();
            else textBox6.Text = "Error";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double r1, r2;
            if (double.TryParse(textBox4.Text, out r1) && double.TryParse(textBox5.Text, out r2))
                textBox6.Text = (r1 * r2).ToString();
            else textBox6.Text = "Error";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            double r1, r2;
            if (double.TryParse(textBox4.Text, out r1) && double.TryParse(textBox5.Text, out r2))
                textBox6.Text = (r1 / r2).ToString();
            else textBox6.Text = "Error";
        }

        //fourth
        private void button3_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            string[] a = textBox7.Text.Split('\n');
            double res;
            foreach (string item in a)
            {
                if (double.TryParse(item, out res))
                    comboBox2.Items.Add(res);
            }
        }

        //fifth
        private void button4_Click(object sender, EventArgs e)
        {
            double stopper = double.Parse(numericUpDown2.Value.ToString());
            double res = 0;
            int i = 1;
            while (1.0 / i > stopper)
            {
                res += 1.0 / i;
                i++;
            }

            textBox8.Text += res.ToString() + "\r\n";
        }

        //sixth
        private void button5_Click(object sender, EventArgs e)
        {
            textBox4NotRealNumbers.Text = "";
            string[] s = textBox4RealNumbers.Text.Split('\n');
            string buf = "";
            double res = 0;

            for (int i = s.Length - 1; i != -1; i--)
            {
                if (!double.TryParse(s[i], out res))
                    buf += s[i] + "\r\n";
            }

            textBox4NotRealNumbers.Text = buf;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            double a = 0;
            double b = 0;
            double h = 0;

            if (double.TryParse(textBox9.Text.ToString(), out a) &&
                double.TryParse(textBox10.Text.ToString(), out b) &&
                double.TryParse(textBox11.Text.ToString(), out h))
            {
                if (b <= a)
                {
                    MessageBox.Show("Значение b должно превышать значение a");
                    return;
                }
                if (h <= 0)
                {
                    MessageBox.Show("Значение h должно превышать 0");
                    return;
                }
                textBox12.Text = "";
                for (double i = a; i <= b; i += h)
                {
                    textBox12.Text += "x = " + i + "; f(" + i + ") = " + f(i) + "\r\n";
                }
            }
            else
                MessageBox.Show("Введите корректные значения для a, b и h");
        }

        private double f(double x)
        {
            return Math.Sin(x / 57.3) / (Math.Abs(x) + 1);
        }
    }
}
