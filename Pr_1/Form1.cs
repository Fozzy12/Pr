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
        Button[] B;
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            B = new Button[16];
            B[0] = button1;
            B[1] = button2;
            B[2] = button3;
            B[3] = button4;
            B[4] = button5;
            B[5] = button6;
            B[6] = button7;
            B[7] = button8;
            B[8] = button9;
            B[9] = button10;
            B[10] = button11;
            B[11] = button12;
            B[12] = button13;
            B[13] = button14;
            B[14] = button15;
            B[15] = button16;
        }
        private void ShuffleButtons()
        {
            // Перемешивание кнопок случайным образом
            int[] numbers = Enumerable.Range(1, 15).ToArray();
            numbers = numbers.OrderBy(x => random.Next()).ToArray();

            for (int i = 0; i < 15; i++)
            {
                B[i].Text = numbers[i].ToString();
                B[i].Visible = true;
            }

            B[15].Visible = false; // Скрыть последнюю (пустую) кнопку
        }

        private bool CheckForWin()
        {
            // Проверяем, упорядочены ли кнопки по порядку чисел от 1 до 15
            return B.Take(15).Select((btn, index) => btn.Text == (index + 1).ToString()).All(x => x);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button bcklick = (Button)sender;
            int n = (int)Convert.ToInt64(bcklick.Tag.ToString());
            n--;
            int y = n / 4;
            int x = n - y * 4;
            int yu, yd;
            int xl, xr;
            yu = y - 1;
            yd = y + 1;
            xl = x - 1;
            xr = x + 1;
            if (xr < 4)
            {
                int nr = y * 4 + xr;
                if (!B[nr].Visible)
                {
                    B[nr].Visible = true;
                    B[n].Visible = false;
                    B[nr].Text = B[n].Text;
                }
            }
            if (xl >= 0)
            {
                int nl = y * 4 + xl;
                if (!B[nl].Visible)
                {
                    B[nl].Visible = true;
                    B[n].Visible = false;
                    B[nl].Text = B[n].Text;
                }
            }
            if (yu >= 0)
            {
                int nu = yu * 4 + x;
                if (!B[nu].Visible)
                {
                    B[nu].Visible = true;
                    B[n].Visible = false;
                    B[nu].Text = B[n].Text;
                }
            }
            if (yd < 4)
            {
                int nd = yd * 4 + x;
                if (!B[nd].Visible)
                {
                    B[nd].Visible = true;
                    B[n].Visible = false;
                    B[nd].Text = B[n].Text;
                }
            }
            if (CheckForWin())
            {
                MessageBox.Show("Поздравляем! Вы выиграли!");
            }


        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ShuffleButtons();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
