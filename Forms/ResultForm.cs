using System;
using System.Drawing;
using System.Windows.Forms;

namespace Forms
{
    public partial class ResultForm : Form
    {
        
        public ResultForm()
        {
            InitializeComponent();
            this.MaximumSize = new Size(500,200);
            // выводим результат в label
            ResultLabel.Text = InputForm.CommonResult;
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {

        }

        private void ResultLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
