using System;
using System.Windows.Forms;

namespace Forms
{
    public partial class MainForm : Form
    {
        // информация
        public string information = "Created by Vladimir Vlasoff\nMinin University\nGroup: Пим-18";

        

        // вывод информации
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(information);
        }

        public MainForm()
        {
            InitializeComponent();
        }

        // переход на форму ввода
        private void InputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var inputForm = new InputForm();
            inputForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // переход на форму результатов
        private void CalcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ResultForm();
            form.Show();
            
        }
    }
}
