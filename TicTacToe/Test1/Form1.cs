using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test1
{
    public partial class Form1 : Form
    {
        public static bool p1Clicked = false, isEnd = false, isDraw = false;
        public static string p1Sign = "X", p2Sign = "O", winner = "";
        public static int p1Score = 0, p2Score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Clicked(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            

            if (isEnd == false)
            {
                IsEnd();
                if (p1Clicked == false && btn.Text.Length == 0)
                {
                    btn.Text = p1Sign;
                    p1Clicked = true;
                    WinnerStatus();
                }
                else if (p1Clicked == true && btn.Text.Length == 0)
                {
                    btn.Text = p2Sign;
                    p1Clicked = false;
                    WinnerStatus();
                }
            }
            if (isEnd == false)
            {
                if (p1Clicked == true)
                {
                    lblTurn.Text = "Turn: Player2";
                }
                else
                {
                    lblTurn.Text = "Turn: Player1";
                }
            }
            else
            {
                lblTurn.Text = "";
            }
        }

        private void WinnerStatus()
        {
            IsEnd();
            if (isEnd == true && isDraw == false)
            {
                lblFinish.Text = winner + " you win!";
            }
            else if (isEnd == true && isDraw == true)
            {
                lblFinish.Text = winner;
            }
            if (isEnd == true && winner == "Player 1")
            {
                lbl1S.Text = "X: " + p1Score;
            }
            else if (isEnd == true && winner == "Player 2")
            {
                lbl2S.Text = "O: " + p2Score;
            }
        }

        private void IsEnd()
        {
            if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X")
            {
                isEnd = true;
                winner = "Player 1";
                p1Score += 1;                
            }
            if (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X")
            {
                isEnd = true;
                winner = "Player 1";
                p1Score += 1;
            }
            if (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X")
            {
                isEnd = true;
                winner = "Player 1";
                p1Score += 1;
            }
            if (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X")
            {
                isEnd = true;
                winner = "Player 1";
                p1Score += 1;
            }
            if (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X")
            {
                isEnd = true;
                winner = "Player 1";
                p1Score += 1;
            }
            if (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X")
            {
                isEnd = true;
                winner = "Player 1";
                p1Score += 1;
            }
            if (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X")
            {
                isEnd = true;
                winner = "Player 1";
                p1Score += 1;
            }
            if (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X")
            {
                isEnd = true;
                winner = "Player 1";
                p1Score += 1;
            }

            //player 2
            if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O")
            {
                isEnd = true;
                winner = "Player 2";
                p2Score += 1;
            }
            if (btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O")
            {
                isEnd = true;
                winner = "Player 2";
                p2Score += 1;
            }
            if (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O")
            {
                isEnd = true;
                winner = "Player 2";
                p2Score += 1;
            }
            if (btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O")
            {
                isEnd = true;
                winner = "Player 2";
                p2Score += 1;
            }
            if (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O")
            {
                isEnd = true;
                winner = "Player 2";
                p2Score += 1;
            }
            if (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O")
            {
                isEnd = true;
                winner = "Player 2";
                p2Score += 1;
            }
            if (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O")
            {
                isEnd = true;
                winner = "Player 2";
                p2Score += 1;
            }
            if (btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O")
            {
                isEnd = true;
                winner = "Player 2";
                p2Score += 1;
            }
            else
            {
                if (btn1.Text.Length > 0 && btn3.Text.Length > 0 && btn4.Text.Length > 0 && btn5.Text.Length > 0 && btn6.Text.Length > 0 && btn2.Text.Length > 0 && btn7.Text.Length > 0 && btn8.Text.Length > 0 && btn9.Text.Length > 0)
                {
                    isEnd = true;
                    isDraw = true;
                    winner = "Draw";
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            winner = "";
            lblFinish.Text = "";
            lblTurn.Text = "";
            isEnd = false;
            isDraw = false;
            p1Clicked = false;
        }
    }
}
