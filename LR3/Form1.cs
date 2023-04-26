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

namespace LR3
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
            // Считывание введенных данных
            double x0 = Convert.ToDouble(inpX0.Text);
            double xk = Convert.ToDouble(inpKx.Text);
            double dx = Convert.ToDouble(inpDx.Text);
            double a = Convert.ToDouble(inpA.Text);
            output.Text = "Работу выполнил ст. Захаров Н.А. 22-ИБ429" + Environment.NewLine; //вывод первой строки

            // Цикл для подсчета
            double x = x0;
            while (x <= (xk + dx / 2))
            {
                double y = a * Math.Log(x);
                output.Text += "x=" + Convert.ToString(x) +
                "; y=" + Convert.ToString(y) + Environment.NewLine;
                x = x + dx;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            //Очистка введенных и полученых данных
            inpX0.Text = null;
            inpKx.Text = null;
            inpDx.Text = null;
            output.Text = null;
        }
    }
}
