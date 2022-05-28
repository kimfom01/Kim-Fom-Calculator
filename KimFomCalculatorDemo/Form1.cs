using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KimFomCalculatorDemo
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string Operation;
        public Form1()
        {
            InitializeComponent();
        }

        // Methods to display the number that was clicked
        private void btn1_Click(object sender, EventArgs e)
        {
            if (textInputBox.Text == "0" && textInputBox.Text != null)
                textInputBox.Text = "1";
            else
                textInputBox.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (textInputBox.Text == "0" && textInputBox.Text != null)
                textInputBox.Text = "2";
            else
                textInputBox.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (textInputBox.Text == "0" && textInputBox.Text != null)
                textInputBox.Text = "3";
            else
                textInputBox.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (textInputBox.Text == "0" && textInputBox.Text != null)
                textInputBox.Text = "4";
            else
                textInputBox.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (textInputBox.Text == "0" && textInputBox.Text != null)
                textInputBox.Text = "5";
            else
                textInputBox.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (textInputBox.Text == "0" && textInputBox.Text != null)
                textInputBox.Text = "6";
            else
                textInputBox.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (textInputBox.Text == "0" && textInputBox.Text != null)
                textInputBox.Text = "7";
            else
                textInputBox.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (textInputBox.Text == "0" && textInputBox.Text != null)
                textInputBox.Text = "8";
            else
                textInputBox.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (textInputBox.Text == "0" && textInputBox.Text != null)
                textInputBox.Text = "9";
            else
                textInputBox.Text += "9";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (textInputBox.Text == "0" && textInputBox.Text != null)
                textInputBox.Text = "0";
            else
                textInputBox.Text += "0";
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (textInputBox.Text != null && !textInputBox.Text.Contains("."))
            {
                textInputBox.Text += ".";
            }
        }

        /// <summary>
        /// Method to find the sum of the numbers that were clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textInputBox.Text);
            textInputBox.Text = "0";
            Operation = "+";
        }
        /// <summary>
        /// Method to find the difference of the numbers that were clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textInputBox.Text);
            textInputBox.Text = "0";
            Operation = "-";
        }
        /// <summary>
        /// Method to find the product of the numbers that were clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textInputBox.Text);
            textInputBox.Text = "0";
            Operation = "*";
        }
        /// <summary>
        /// Method to find the quotient of the numbers that were clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDivide_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textInputBox.Text);
            textInputBox.Text = "0";
            Operation = "/";
        }
        /// <summary>
        /// Method to clear the text field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            textInputBox.Text = "0";
        }
        /// <summary>
        /// Method to find the integer quotient of the numbers that were clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDIV_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textInputBox.Text);
            textInputBox.Text = "0";
            Operation = "DIV";
        }
        /// <summary>
        /// Method to find the modulus (remainder) of the numbers that were clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMOD_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textInputBox.Text);
            textInputBox.Text = "0";
            Operation = "MOD";
        }
        /// <summary>
        /// Method to delete the last number that was clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string text = textInputBox.Text;
            text = text.Replace(textInputBox.Text[text.Length - 1].ToString(), "");
            textInputBox.Text = text;
            FirstNumber = Convert.ToDouble(textInputBox.Text);
        }
        /// <summary>
        /// Method to display the result 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEquals_Click(object sender, EventArgs e)
        {
            double SecondNumber, Result;

            SecondNumber = Convert.ToDouble(textInputBox.Text);
            switch (Operation)
            {
                case "+":
                    Result = FirstNumber + SecondNumber;
                    textInputBox.Text = Convert.ToString(Result);
                    break;
                case "-":
                    Result = FirstNumber - SecondNumber;
                    textInputBox.Text = Convert.ToString(Result);
                    break;
                case "*":
                    Result = FirstNumber * SecondNumber;
                    textInputBox.Text = Convert.ToString(Result);
                    break;
                case "/":
                    if (SecondNumber != 0)
                    {
                        Result = FirstNumber / SecondNumber;
                        textInputBox.Text = Convert.ToString(Result);
                    }
                    else
                        textInputBox.Text = "Error! Division by 0";
                    break;
                case "DIV":
                    if (SecondNumber != 0)
                    {
                        Result = (int)(FirstNumber / SecondNumber);
                        textInputBox.Text = Convert.ToString(Result);
                    }
                    else
                        textInputBox.Text = "Error! Division by 0";
                    break;
                case "MOD":
                    if (SecondNumber != 0)
                    {
                        Result = FirstNumber % SecondNumber;
                        textInputBox.Text = Convert.ToString(Result);
                    }
                    else
                        textInputBox.Text = "Error! Division by 0";
                    break;
            }
        }
    }
}
