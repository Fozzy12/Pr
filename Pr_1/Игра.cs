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
    public partial class Игра : Form
    {
        public Игра()
        {
            InitializeComponent();
        }

        private void Игра_Load(object sender, EventArgs e)
        {
            // Создаем экземпляр игры пятнашки
            FifteenGame game = new FifteenGame();

            // Получаем список чисел для отображения в TableLayoutPanel
            List<int> numbers = game.GetNumbers();

            // Получаем количество строк и столбцов для TableLayoutPanel
            int rows = game.Rows;
            int cols = game.Cols;

            // Настраиваем TableLayoutPanel
            tlPanel.RowCount = rows;
            tlPanel.ColumnCount = cols;

                    // Заполняем TableLayoutPanel числами
            for (int i = 0; i < rows; i++)
            {
               for (int j = 0; j < cols; j++)
               {
                 Button button = new Button();
                 button.Text = numbers[i * cols + j].ToString();
                 button.Dock = DockStyle.Fill;
                 tlPanel.Controls.Add(button, j, i);
               }
            }
        }

        public class FifteenGame
        {
            private int[,] board;
            private int rows;
            private int cols;

            public FifteenGame()
            {
                rows = 4;
                cols = 4;

                board = new int[rows, cols];

                int counter = 1;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        board[i, j] = counter++;
                    }
                }

                // Set last element to 0
                board[rows - 1, cols - 1] = 0;
            }

            public int Rows { get { return rows; } }
            public int Cols { get { return cols; } }

            public List<int> GetNumbers()
            {
                List<int> numbers = new List<int>();

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        numbers.Add(board[i, j]);
                    }
                }

                return numbers;
            }
        }

    }
}
