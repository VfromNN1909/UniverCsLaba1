using System;
using System.Windows.Forms;

namespace Forms
{
    public partial class InputForm : Form
    {
        // результат
        public static String CommonResult;

        public InputForm()
        {
            InitializeComponent();
            // максимальный размер
            this.MaximumSize = new System.Drawing.Size(400, 400);
            CommonResult = "";
            
        }

        private void InputForm_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        // обработчик нажатия на кнопку
        private void Button1_Click(object sender, EventArgs e)
        {
            // сумма
            double sum = 0;
            // НОК
            double LeastMultiple = 0;
            // если 1ый чекбокс выбран
            if (checkBox1.Checked)
            {
                // пытаемся сложить
                try
                {
                    
                     sum = double.Parse(Number1.Text) +
                           double.Parse(Number2.Text) + 
                           double.Parse(Number3.Text);
                }
                // если не получается, то ловим ошибку
                catch
                {
                    // выводим соощение об ошибке
                    MessageBox.Show("Введите числа!");
                }
                // результат
                CommonResult += $"Сумма чисел = {sum}\n";
            }
            // если 2ой чекбокс выбран
            if (checkBox2.Checked)
            {
                // пытаемся найти НОК
                try
                {
                    // НОК
                    LeastMultiple = NOK(double.Parse(Number1.Text),
                                    double.Parse(Number2.Text));
                }
                // если не получается, то ловим ошибку
                catch
                {
                    MessageBox.Show("Введите числа!");
                }
                
                CommonResult += $"Наименьшее общее кратное первых двух чисел: {LeastMultiple}\n";
            }
            // скрываем форму
            Hide();
        }
        
        // функция нахождения НОК
        private double NOK(double a, double b)
        {
            for (double i = a; i < b * a; i += a)
            {
                if (i % a == 0 && i % b == 0) return i;
            }

            return -1;
        }
    }
}
