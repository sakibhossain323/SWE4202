using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator8digit
{
    public partial class Form1 : Form
    {
        Calculator calc = new Calculator();
        private void DisplayResult()
        {
            resultLabel.Text = calc.GetCurOperand();
            prevResultLabel.Text = calc.GetPrevOperand() + " " + calc.GetOperation();
        }

        private void RaiseError()
        {
            calc.Reset();
            calc.SetCurOperand("Error: Press AC");
            DisplayResult();
        }
        public Form1()
        {
            InitializeComponent();
            DisplayResult();
        }

        private void acButton_Click(object sender, EventArgs e)
        {
            calc.Reset();
            DisplayResult();
        }

        
        private void dig0Button_Click(object sender, EventArgs e)
        {
            calc.AppendDigit("0");
            DisplayResult();
        }

        private void dig1Button_Click(object sender, EventArgs e)
        {
            calc.AppendDigit("1");
            DisplayResult();
        }

        private void dig2Button_Click(object sender, EventArgs e)
        {
            calc.AppendDigit("2");
            DisplayResult();
        }

        private void dig3Button_Click(object sender, EventArgs e)
        {
            calc.AppendDigit("3");
            DisplayResult();
        }

        private void dig4Button_Click(object sender, EventArgs e)
        {
            calc.AppendDigit("4");
            DisplayResult();
        }

        private void dig5Button_Click(object sender, EventArgs e)
        {
            calc.AppendDigit("5");
            DisplayResult();
        }

        private void dig6Button_Click(object sender, EventArgs e)
        {
            calc.AppendDigit("6");
            DisplayResult();
        }

        private void dig7Button_Click(object sender, EventArgs e)
        {
            calc.AppendDigit("7");
            DisplayResult();
        }

        private void dig8Button_Click(object sender, EventArgs e)
        {
            calc.AppendDigit("8");
            DisplayResult();
        }

        private void dig9Button_Click(object sender, EventArgs e)
        {
            calc.AppendDigit("9");
            DisplayResult();
        }

        private void pointButton_Click(object sender, EventArgs e)
        {
            calc.AppendDigit(".");
            DisplayResult();
        }

        private void negateButton_Click(object sender, EventArgs e)
        {
            calc.Negate();
            DisplayResult();
        }

        
        private void addButton_Click(object sender, EventArgs e)
        {
            if (calc.GetCurOperand() == "")
            {
                calc.SetOperation("+");
                DisplayResult();
                return;
            }

            if(calc.GetPrevOperand() != "") calc.PerformCalculation();
            string curOp = calc.GetCurOperand();
            if (curOp.Contains("Error"))
            {
                RaiseError();
                return;
            }
            calc.SetPrevOperand(curOp);
            calc.SetCurOperand("");
            calc.SetOperation("+");

            DisplayResult();
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            if (calc.GetCurOperand() == "")
            {
                calc.SetOperation("-");
                DisplayResult();
                return;
            }

            if (calc.GetPrevOperand() != "") calc.PerformCalculation();
            string curOp = calc.GetCurOperand();
            if (curOp.Contains("Error"))
            {
                RaiseError();
                return;
            }
            calc.SetPrevOperand(curOp);
            calc.SetCurOperand("");
            calc.SetOperation("-");

            DisplayResult();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            if (calc.GetCurOperand() == "")
            {
                calc.SetOperation("*");
                DisplayResult();
                return;
            }

            if (calc.GetPrevOperand() != "") calc.PerformCalculation();
            string curOp = calc.GetCurOperand();
            if (curOp.Contains("Error"))
            {
                RaiseError();
                return;
            }
            calc.SetPrevOperand(curOp);
            calc.SetCurOperand("");
            calc.SetOperation("*");

            DisplayResult();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            if (calc.GetCurOperand() == "")
            {
                calc.SetOperation("/");
                DisplayResult();
                return;
            }

            if (calc.GetPrevOperand() != "") calc.PerformCalculation();
            string curOp = calc.GetCurOperand();
            if (curOp.Contains("Error"))
            {
                RaiseError();
                return;
            }
            calc.SetPrevOperand(curOp);
            calc.SetCurOperand("");
            calc.SetOperation("/");

            DisplayResult();
        }

        private void percentButton_Click(object sender, EventArgs e)
        {
            calc.percent();
            DisplayResult();
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            if (calc.GetCurOperand() == "")
            {
                string prevOp = calc.GetPrevOperand();
                calc.Reset();
                calc.SetCurOperand(prevOp);
                DisplayResult();
                return;
            }

            if (calc.GetPrevOperand() != "") calc.PerformCalculation();
            string curOp = calc.GetCurOperand();
            if (curOp.Contains("Error"))
            {
                RaiseError();
                return;
            }
            calc.Reset();
            calc.SetCurOperand(curOp);

            DisplayResult();
        }

    }

}
