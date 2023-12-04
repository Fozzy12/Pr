﻿using System;
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

        private void btnCombination_Click(object sender, EventArgs e)
        {
            // Получаем значения n и m из текстовых полей
            int n = int.Parse(txtn.Text);
            int m = int.Parse(txtm.Text);
            // Вычисляем значение C(m,n)
            double result = CalculateCombination(m, n);
            label3.Text = result.ToString();
        }
        private double CalculateCombination(int m, int n)
        {
            // Вычисляем факториалы чисел m и n
            double factorialM = Factorial1(m);
            double factorialN = Factorial1(n);
            // Вычисляем факториал числа (n-m)
            double factorialNM = Factorial1(n - m);
            // Вычисляем C(m,n)
            double combination = factorialN / (factorialM * factorialNM);
            return combination;
        }
        private double Factorial1(int number)
        {
            // Рекурсивно вычисляем факториал числа number
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return number * Factorial1(number - 1);
            }
        }
    }
}
