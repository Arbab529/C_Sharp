using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Visual_Code
{
    public partial class Nqueen : Form
    {
        public Nqueen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (5== 5)
            {
                int L = 5;
                int x = 20, y = 150;
                S = L;
                int[,] arr = new int[L, L];

                if (!theBoardSolver(arr, 0))
                {  
                    
                }

                for (int i = 0; i < L; i++)
                {
                    for (int j = 0; j < L; j++)
                    {
                        Panel pn = new Panel();
                        pn.Width = 60;
                        pn.Height = 50;
                        pn.Left = x;
                        pn.Top = y;
                        pn.Name = pn + "" + i;
                        pn.BackColor = Color.Green;
                        pn.BackColor = Color.Green;
                        this.Controls.Add(pn);
                        x += 75;
                        if (arr[i, j] == 1)
                        {
                            
                            pn.BackColor = Color.Blue;
                        }
                        if (arr[i,j]==0)
                        {
                            pn.BackColor = Color.Red;
                        }
                    }

                    x = 20;
                    y += 65;
                }
  
        }
}
        static int S;

        static Boolean colorss(int[,] board, int row, int col)
        {
            int i, j;
            for (i = 0; i < col; i++)
            {
                if (board[row, i] == 1)
                return false;
            }

            for (i = row, j = col; i >= 0 && j >= 0; i--, j--)
            {
              
                if (board[i, j] == 1) return false;
            }

            for (i = row, j = col; j >= 0 && i < S; i++, j--)
            {
                if (board[i, j] == 1) return false;
            }
            return true;
        }
        static Boolean theBoardSolver(int[,] board, int col)
        {
            if (col >= S)
                return true;
            for (int i = 0; i < S; i++)
            {
                if (colorss(board, i, col))
                {
                    board[i, col] = 1;
                    if (theBoardSolver(board, col + 1))
                        return true;
                    board[i, col] = 0;
                }
            }
            return false;
        }
    }
}
