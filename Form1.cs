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

        }

        private void button22_Click(object sender, EventArgs e) // 0
        {

        }

        private void button23_Click(object sender, EventArgs e) //запятая
        {

        }

        private void button25_Click(object sender, EventArgs e) // равно
        {

        }

        private void button16_Click(object sender, EventArgs e) // 1
        {

        }

        private void button17_Click(object sender, EventArgs e) //2
        {

        }

        private void button18_Click(object sender, EventArgs e) //3
        {

        }

        private void button19_Click(object sender, EventArgs e)//разделить
        {

        }

        private void button20_Click(object sender, EventArgs e)//плюс
        {

        }

        private void button11_Click(object sender, EventArgs e)//4
        {

        }

        private void button12_Click(object sender, EventArgs e)//5
        {

        }

        private void button13_Click(object sender, EventArgs e)//6
        {

        }

        private void button14_Click(object sender, EventArgs e)//x^2
        {

        }

        private void button15_Click(object sender, EventArgs e)//минус
        {

        }

        private void button6_Click(object sender, EventArgs e)//7
        {

        }

        private void button7_Click(object sender, EventArgs e)//8
        {

        }

        private void button8_Click(object sender, EventArgs e)//9
        {

        }

        private void button9_Click(object sender, EventArgs e)//корень
        {

        }

        private void button10_Click(object sender, EventArgs e)//умножить
        {

        }

        private void button1_Click(object sender, EventArgs e)//процент
        {

        }

        private void button2_Click(object sender, EventArgs e)// CE - очищает только текстбокс
        {
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)// C 
        {
        }

        private void button5_Click(object sender, EventArgs e)// DELETE
        {
            if (textBox1.TextLength < 0)
                return;
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
        }
    }
}
