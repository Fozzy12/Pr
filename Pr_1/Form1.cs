using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtm.Clear();
            txtn.Clear();
        }

        private void BtnPermutation_Click(object sender, EventArgs e)
        {
            // Получаем значение из текстового поля
            int n = int.Parse(txtn.Text);
            // Вычисляем факториал числа n
            int result = Factorial(n);
            label3.Text = result.ToString();
        }
        private int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}
