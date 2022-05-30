using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_Thirteen
{
    public partial class Form1 : Form
    {

        private bool xTurn = true;
        private int[,] matrix = new int[3, 3];
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Box Number One. Top Corner
        private void button1_1_Click(object sender, EventArgs e)
        {
            if (xTurn)
            {
                button1_1.Text = "X";
                matrix[0, 0] = 1;
            }
            else
            {
                button1_1.Text = "O";
                matrix[0, 0] = 2;
            }
            xTurn = !xTurn;
            checkWinner();
            button1_1.Enabled = false;
        }

        //box number two. first row middle botton
        private void button1_2_Click(object sender, EventArgs e)
        {
            if (xTurn)
            {
                button1_2.Text = "X";
                matrix[0, 1] = 1;
            }
            else
            {
                button1_2.Text = "O";
                matrix[0, 1] = 2;
            }
            xTurn = !xTurn;
            checkWinner();
            button1_2.Enabled = false;
        }

        private void button1_3_Click(object sender, EventArgs e)
        {
            if (xTurn)
            {
                button1_3.Text = "X";
                matrix[0, 2] = 1;
            }
            else
            {
                button1_3.Text = "O";
                matrix[0, 2] = 2;
            }
            xTurn = !xTurn;
            checkWinner();
            button1_3.Enabled = false;
        }

        private void button2_1_Click(object sender, EventArgs e)
        {
            if (xTurn)
            {
                button2_1.Text = "X";
                matrix[1, 0] = 1;
            }
            else
            {
                button2_1.Text = "O";
                matrix[1, 0] = 2;
            }
            xTurn = !xTurn;
            checkWinner();
            button2_1.Enabled = false;
        }

        private void button2_2_Click(object sender, EventArgs e)
        {
            if (xTurn)
            {
                button2_2.Text = "X";
                matrix[1, 1] = 1;
            }
            else
            {
                button2_2.Text = "O";
                matrix[1, 1] = 2;
            }
            xTurn = !xTurn;
            checkWinner();
            button2_2.Enabled = false;
        }

        private void button2_3_Click(object sender, EventArgs e)
        {
            if (xTurn)
            {
                button2_3.Text = "X";
                matrix[1, 2] = 1;
            }
            else
            {
                button2_3.Text = "O";
                matrix[1, 2] = 2;
            }
            xTurn = !xTurn;
            checkWinner();
            button2_3.Enabled = false;
        }

        private void button3_1_Click(object sender, EventArgs e)
        {
            if (xTurn)
            {
                button3_1.Text = "X";
                matrix[2, 0] = 1;
            }
            else
            {
                button3_1.Text = "O";
                matrix[2, 0] = 2;
            }
            xTurn = !xTurn;
            checkWinner();
            button3_1.Enabled = false;
        }

        private void button3_2_Click(object sender, EventArgs e)
        {
            if (xTurn)
            {
                button3_2.Text = "X";
                matrix[2, 1] = 1;
            }
            else
            {
                button3_2.Text = "O";
                matrix[2, 1] = 2;
            }
            xTurn = !xTurn;
            checkWinner();
            button3_2.Enabled = false;
        }

        private void button3_3_Click(object sender, EventArgs e)
        {
            if (xTurn)
            {
                button3_3.Text = "X";
                matrix[2, 2] = 1;
            }
            else
            {
                button3_3.Text = "O";
                matrix[2, 2] = 2;
            }
            xTurn = !xTurn;
            checkWinner();
            button3_3.Enabled = false;
        }

        private void checkWinner()
        {
            // Rows 
            if (matrix[0, 0] == matrix[0, 1] && matrix[0, 0] == matrix[0, 2])
            {
                if (matrix[0, 0] == 1)
                    label2.Text = "Player X";
                else if (matrix[0, 0] == 2)
                    label2.Text = "Player O";
            }
            else if (matrix[1, 0] == matrix[1, 1] && matrix[1, 0] == matrix[1, 2])
            {
                if (matrix[1, 0] == 1)
                    label2.Text = "Player X";
                else if (matrix[1, 0] == 2)
                    label2.Text = "Player O";
            }
            else if (matrix[2, 0] == matrix[2, 1] && matrix[2, 0] == matrix[2, 2])
            {
                if (matrix[2, 0] == 1)
                    label2.Text = "Player X";
                else if (matrix[2, 0] == 2)
                    label2.Text = "Player O";
            }


            // colloms 
            if (matrix[0, 0] == matrix[1, 0] && matrix[0, 0] == matrix[2, 0])
                {
                    if (matrix[0, 0] == 1)
                        label2.Text = "Player X";
                    else if (matrix[0, 0] == 2)
                        label2.Text = "Player O";
                }
            else if (matrix[0, 1] == matrix[1, 1] && matrix[0, 1] == matrix[2, 1])
                {
                    if (matrix[0, 1] == 1)
                        label2.Text = "Player X";
                    else if (matrix[0, 1] == 2)
                        label2.Text = "Player O";
                }
            else if (matrix[0, 0] == matrix[1, 0] && matrix[0, 2] == matrix[2, 2])
                {
                    if (matrix[0, 2] == 1)
                        label2.Text = "Player X";
                    else if (matrix[0, 2] == 2)
                        label2.Text = "Player O";
                }



            if (matrix[0, 0] == matrix[1, 1] && matrix[0, 0] == matrix[2, 2])
                {
                    if (matrix[0, 0] == 1)
                        label2.Text = "Player X";
                    else if (matrix[0, 0] == 2)
                        label2.Text = "Player 0";
                }
            else if (matrix[0, 2] == matrix[1, 1] && matrix[0, 2] == matrix[2, 0])
                {
                    if (matrix[0, 2] == 1)
                        label2.Text = "Player X";
                    else if (matrix[0, 2] == 2)
                        label2.Text = "Player 0";
                }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    matrix[i, j] = 0;
        }

    }
}
