using System;

using System.Windows.Forms;


namespace LR_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          inpX.Text = "3,4";  //значение Х при запуске 
          inpY.Text = "0,74"; //значение Y при запуске
          inpZ.Text = "19,3"; //значение Z при запуске
          output.Text = "Лаб.раб N1. Ст. гр 22-ИБ429 Захаров Н.А."; //вывод первой строки в поле ответа
        }

        private void perform_Click(object sender, EventArgs e)
        {
            double x = double.Parse(inpX.Text);//считывание значения Х
            output.Text += Environment.NewLine + "X = " + x.ToString(); //запись значения х в окно вывода на новой строке
            double y = double.Parse(inpY.Text); //считывание значения y
            output.Text += Environment.NewLine + "Y = " + y.ToString(); //запись значения y в окно вывода на новой строке
            double z = double.Parse(inpY.Text); //считывание значения z
            output.Text += Environment.NewLine + "Z = " + z.ToString(); //запись значения z в окно вывода на новой строке
                                                                        
            //вычисления
            double a = Math.Tan(x + y) * Math.Tan(x + y);
            double b = Math.Exp(y - z);
            double c = Math.Sqrt(Math.Cos(x * x) + Math.Sin(z * z));
            double u = a - b * c;
            output.Text += Environment.NewLine + "Результат U = " + u.ToString(); //вывод ответа в окно вывода на новую строку

        }
    }
}
