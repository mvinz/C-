using System;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        public static string prevOperand = "", operation = "";
        public static double answer = 0;
        public static bool clicked = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void OtherClicks(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            switch (btn.Name)
            {
                case "btnCE":
                    display1.Text = "";
                    break;
                case "btnC":
                    display1.ResetText();
                    prevOperand = "";
                    answer = 0;
                    display2.ResetText();
                    clicked = false;
                    break;
                case "btnDel":
                    if (display1.Text.Length > 0)
                    {
                        display1.Text = display1.Text.Substring(0, display1.Text.Length - 1);
                    }
                    break;
                case "btnPlusMinus":
                    if (display1.Text.Length > 0)
                    {
                        if (!display1.Text.Contains("-"))
                        {
                            display1.Text = "-" + display1.Text;
                        }
                        else
                        {
                            display1.Text = display1.Text.Substring(1, display1.Text.Length - 1);
                        }
                    }
                    break;
                case "btnDecimal":
                    if (display1.Text.Length > 0)
                    {
                        if (!display1.Text.Contains("."))
                        {
                            display1.Text += ".";
                        }
                    }
                    else 
                    {
                        display1.Text = "0.";
                    }
                    break;
                default:
                    display1.Text += btn.Text;
                    break;
            }
        }

        private void OperationCLicks(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Text)
            {
                case "+":
                    if (display1.Text.Length > 0)
                    {
                        if (clicked == false)
                        {
                            prevOperand = display1.Text;
                            display2.Text = prevOperand + " + ";
                            operation = "+";
                            display1.ResetText();
                            clicked = true;
                        }
                        else
                        {
                            Solve();
                            prevOperand = answer.ToString();
                            operation = "+";
                            display2.Text = answer.ToString() + " + ";
                            display1.ResetText();
                        }
                    }
                    break;
                case "-":
                    if (display1.Text.Length > 0)
                    {
                        if (clicked == false)
                        {
                            prevOperand = display1.Text;
                            display2.Text = prevOperand + " - ";
                            operation = "-";
                            display1.ResetText();
                            clicked = true;
                        }
                        else
                        {
                            Solve();
                            prevOperand = answer.ToString();
                            operation = "-";
                            display2.Text = answer.ToString() + " - ";
                            display1.ResetText();
                        }
                    }
                    break;
                case "X":
                    if (display1.Text.Length > 0)
                    {
                        if (clicked == false)
                        {
                            prevOperand = display1.Text;
                            display2.Text = prevOperand + " X ";
                            operation = "X";
                            display1.ResetText();
                            clicked = true;
                        }
                        else
                        {
                            Solve();
                            prevOperand = answer.ToString();
                            operation = "X";
                            display2.Text = answer.ToString() + " X ";
                            display1.ResetText();
                        }
                    }
                    break;
                case "÷":
                    if (display1.Text.Length > 0)
                    {
                        if (clicked == false)
                        {
                            prevOperand = display1.Text;
                            display2.Text = prevOperand + " ÷ ";
                            operation = "÷";
                            display1.ResetText();
                            clicked = true;
                        }
                        else
                        {
                            Solve();
                            prevOperand = answer.ToString();
                            operation = "÷";
                            display2.Text = answer.ToString() + " ÷ ";
                            display1.ResetText();
                        }
                    }
                    break;
                case "=":
                    if (display1.Text.Length > 0)
                    {
                        Solve();
                        display1.Text = answer.ToString();
                        display2.ResetText();
                        prevOperand = "";
                        operation = "";
                        clicked = false;
                    }
                    else if(display2.Text.Length > 0)
                    {
                        display1.Text = prevOperand;
                        display2.ResetText();
                        prevOperand = "";
                        operation = "";
                        clicked = false;
                    }
                    break;
            }
        }

        private void Solve()
        {
            if (operation == "+")
            {
                answer = Convert.ToDouble(prevOperand) + Convert.ToDouble(display1.Text);
            }
            else if (operation == "-")
            {
                answer = Convert.ToDouble(prevOperand) - Convert.ToDouble(display1.Text);
            }
            else if (operation == "X")
            {
                answer = Convert.ToDouble(prevOperand) * Convert.ToDouble(display1.Text);
            }
            else if (operation == "÷")
            {
                answer = Convert.ToDouble(prevOperand) / Convert.ToDouble(display1.Text);
            }
        }
    }
}
