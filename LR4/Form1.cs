using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LR4
{
    public partial class Form1 : Form
    {
        int[] list = new int[15]; // заводим целочисленный класс
        public Form1()
        {         
            InitializeComponent();
        }

        private void fill_Click(object sender, EventArgs e)
        {
            Random rand = new Random(); //объявляем случайную выборку
            inputArr.Text = "";
            for (int i = 0; i < 15; i++)//цикл с 0 по 15 делаем +1
            {
                list[i] = rand.Next(-50, 50);//заполняем случайными данными рандома от -50 до 50
                inputArr.Text += "list[" + Convert.ToString(i) + "] = "
                + Convert.ToString(list[i]) + Environment.NewLine;
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            outputArr.Text = "";//заполняем второй текст бокс
            for (int i = 0; i < 15; i++)
            {
                if (list[i] < 0) list[i] = 0;//если значение в 1м текстбоксе меньше 0 то меняем его на 0
                outputArr.Text += "list[" + Convert.ToString(i) + "] = "
                + Convert.ToString(list[i]) + Environment.NewLine;
            }
        }
    }
}
