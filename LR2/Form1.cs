using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LR2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(inpX.Text); // считывание значения x
            double y = Convert.ToDouble(inpY.Text); // считывание значения y
            double z = Convert.ToDouble(inpZ.Text); // считывание значения z

            // прием исходных и полученных данных в окно результатов
            output.Text = "Результаты работы программы ст. Захарова Н.А. 22-ИБ429" +
            Environment.NewLine;
            output.Text += "При X = " + inpX.Text + Environment.NewLine;
            output.Text += "При Y = " + inpY.Text + Environment.NewLine;
            output.Text += "При Z = " + inpZ.Text + Environment.NewLine;

            // Определение номера выбранного радиобокса
            int n = 0;
            if (radioButton2.Checked) n = 1;
            else if (radioButton3.Checked) n = 2;

            // Вычисление U
            double u;
            switch (n)
            {
                case 0:
                    if ((z - x) == 0) u = y * Math.Sin(x) * Math.Sin(x) + z;
                    else if ((z - x) < 0) u = y * Math.Exp(Math.Sin(x)) - z;
                    else u = y * Math.Sin(Math.Sin(x)) + z;
                    output.Text += "U = " + Convert.ToString(u) + Environment.NewLine;
                    break;
                case 1:
                    if ((z - x) == 0) u = y * Math.Cos(x) * Math.Cos(x) + z;
                    else if ((z - x) < 0) u = y * Math.Exp(Math.Cos(x)) - z;
                    else u = y * Math.Sin(Math.Cos(x)) + z;
                    output.Text += "U = " + Convert.ToString(u) + Environment.NewLine;
                    break;
                case 2:
                    if ((z - x) == 0) u = y * Math.Exp(x) * Math.Exp(x) + z;
                    else if ((z - x) < 0) u = y * Math.Exp(Math.Exp(x)) - z;
                    else u = y * Math.Sin(Math.Exp(x)) + z;
                    output.Text += "U = " + Convert.ToString(u) + Environment.NewLine;
                    break;
                default:
                    output.Text += "Решение не найдено" + Environment.NewLine;
                    break;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            //очистка текстовых полей (данных) при нажатии кнопки очистить
            inpX.Text = null;
            inpY.Text = null;
            inpZ.Text = null;
            output.Text = null;
        }
    }
}
