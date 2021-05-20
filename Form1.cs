using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        double firstNum = 0;
        string symbol = String.Empty;
        double secondNum = 0;


        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e) //метод копирования
        {
            if ((textBox1.Text != "") || (textBox1.Text != null))
                Clipboard.SetText(textBox1.Text);
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e) //метод вставки
        {
            float symbol;
            if (!String.IsNullOrEmpty(Clipboard.GetText()))
                if (float.TryParse(Clipboard.GetText(), out symbol))
                    textBox1.Text = (Clipboard.GetText());
        }

        private void справкаToolStripMenuItem1_Click(object sender, EventArgs e) // справка
        {
            MessageBox.Show("Программа разработанная по заданию в PR8!\nСоздатели этой программы:\n*Антонов Александр\n*Артем Морозов\n*Анастасия Прохорова.", "Pr8 - Information", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }

        private void button21_Click(object sender, EventArgs e) // +-
        {
            if (textBox1.Text[0] == '-')
                textBox1.Text = textBox1.Text.Remove(0, 1);
            else
                textBox1.Text = "-" + textBox1.Text;
        }

        private void button22_Click(object sender, EventArgs e) // 0
        {
            textBox1.Text += "0";
        }

        private void button23_Click(object sender, EventArgs e) //запятая
        {
            textBox1.Text += ",";
        }

        private void button25_Click(object sender, EventArgs e) // равно
        {
            if (textBox1.Text.ToString() != String.Empty && symbol != String.Empty)
            {
                Double.TryParse(textBox1.Text.ToString(), out secondNum);
                if (symbol == "+")
                {
                    button20.ForeColor = Color.Black;
                    textBox1.Text = (firstNum + secondNum).ToString();
                }
                if (symbol == "-")
                {
                    button15.ForeColor = Color.Black;
                    textBox1.Text = (firstNum - secondNum).ToString();

                }
                if (symbol == "*")
                {
                    button10.ForeColor = Color.Black;
                    textBox1.Text = (firstNum * secondNum).ToString();

                }
                if (symbol == "/")
                {
                    button19.ForeColor = Color.Black;
                    textBox1.Text = (firstNum / secondNum).ToString();
                }
                symbol = String.Empty;
            }
        }

        private void button16_Click(object sender, EventArgs e) // 1
        {
            textBox1.Text += "1";
        }

        private void button17_Click(object sender, EventArgs e) //2
        {
            textBox1.Text += "2";
        }

        private void button18_Click(object sender, EventArgs e) //3
        {
            textBox1.Text += "3";
        }

        private void button19_Click(object sender, EventArgs e)//разделить
        {
            if (textBox1.Text.ToString() != String.Empty && symbol == String.Empty)
            {
                button19.ForeColor = Color.Red;
                symbol = "/";
                Double.TryParse(textBox1.Text.ToString(), out firstNum);
                textBox1.Clear();
            }
        }

        private void button20_Click(object sender, EventArgs e)//плюс
        {
            if (textBox1.Text.ToString() != String.Empty && symbol == String.Empty)
            {
                button20.ForeColor = Color.Red;
                symbol = "+";
                Double.TryParse(textBox1.Text.ToString(), out firstNum);
                textBox1.Clear();
            }
        }

        private void button11_Click(object sender, EventArgs e)//4
        {
            textBox1.Text += "4";
        }

        private void button12_Click(object sender, EventArgs e)//5
        {
            textBox1.Text += "5";
        }

        private void button13_Click(object sender, EventArgs e)//6
        {
            textBox1.Text += "6";
        }

        private void button14_Click(object sender, EventArgs e)//x^2
        {
            if (textBox1.Text.ToString() != String.Empty)
            {
                double kor;
                Double.TryParse(textBox1.Text.ToString(), out kor);
                firstNum = kor;
                textBox1.Text = Math.Pow(kor,2).ToString();
            }
        }

        private void button15_Click(object sender, EventArgs e)//минус
        {
            if (textBox1.Text.ToString() != String.Empty && symbol == String.Empty)
            {
                button15.ForeColor = Color.Red;
                symbol = "-";
                Double.TryParse(textBox1.Text.ToString(), out firstNum);
                textBox1.Clear();
            }
        }

        private void button6_Click(object sender, EventArgs e)//7
        {
            textBox1.Text += "7";
        }

        private void button7_Click(object sender, EventArgs e)//8
        {
            textBox1.Text += "8";
        }

        private void button8_Click(object sender, EventArgs e)//9
        {
            textBox1.Text += "9";
        }

        private void button9_Click(object sender, EventArgs e)//корень
        {
            if (textBox1.Text.ToString() != String.Empty && textBox1.Text[0] == '-')
            {
                double kor;
                Double.TryParse(textBox1.Text.ToString(), out kor);
                firstNum = kor;
                textBox1.Text = Math.Sqrt(kor).ToString();
            }
        }

        private void button10_Click(object sender, EventArgs e)//умножить
        {
            if (textBox1.Text.ToString() != String.Empty && symbol == String.Empty)
            {
                button10.ForeColor = Color.Red;
                symbol = "*";
                Double.TryParse(textBox1.Text.ToString(), out firstNum);
                textBox1.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)//процент
        {
            if (textBox1.Text.ToString() != String.Empty && textBox1.Text[0] != '-')
            {
                Double.TryParse(textBox1.Text.ToString(), out secondNum);
                if (firstNum == 0)
                {
                    textBox1.Text = "0";
                    secondNum = 0;
                }
                    textBox1.Text = (((secondNum / 100) * firstNum)).ToString();
                    secondNum = (secondNum / 100) * firstNum;
            }
        }

        private void button2_Click(object sender, EventArgs e)// CE - очищает только текстбокс
        {
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)// C 
        {
            textBox1.Clear();
            firstNum = 0;
            symbol = String.Empty;
            secondNum = 0;

            button20.ForeColor = Color.Black;
            button19.ForeColor = Color.Black;
            button10.ForeColor = Color.Black;
            button15.ForeColor = Color.Black;
        }

        private void button5_Click(object sender, EventArgs e)// DELETE
        {
            if (textBox1.TextLength < 0)
                return;
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
        }
    }
}
