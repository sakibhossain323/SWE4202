using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EightDigitCalculator
{
    public partial class CalculatorForm : Form
    {
        Calculator calc = new Calculator();
        private void DisplayResult()
        {
            LabelResult.Text = calc.CurOperand;
            LabelPrevResult.Text = calc.PrevOperand + " " + calc.Operation;
        }

        private void RaiseError()
        {
            calc.Reset();
            calc.CurOperand = "Error: Press AC";
            DisplayResult();
        }
        public CalculatorForm()
        {
            InitializeComponent();
            DisplayResult();
        }

        private void ButtonAC_Click(object sender, EventArgs e)
        {
            calc.Reset();
            DisplayResult();
        }

        
        private void ButtonDig0_Click(object sender, EventArgs e)
        {
            calc.AppendDigit("0");
            DisplayResult();
        }

        private void ButtonDig1_Click(object sender, EventArgs e)
        {
            calc.AppendDigit("1");
            DisplayResult();
        }

        private void ButtonDig2_Click(object sender, EventArgs e)
        {
            calc.AppendDigit("2");
            DisplayResult();
        }

        private void ButtonDig3_Click(object sender, EventArgs e)
        {
            calc.AppendDigit("3");
            DisplayResult();
        }

        private void ButtonDig4_Click(object sender, EventArgs e)
        {
            calc.AppendDigit("4");
            DisplayResult();
        }

        private void ButtonDig5_Click(object sender, EventArgs e)
        {
            calc.AppendDigit("5");
            DisplayResult();
        }

        private void ButtonDig6_Click(object sender, EventArgs e)
        {
            calc.AppendDigit("6");
            DisplayResult();
        }

        private void ButtonDig7_Click(object sender, EventArgs e)
        {
            calc.AppendDigit("7");
            DisplayResult();
        }

        private void ButtonDig8_Click(object sender, EventArgs e)
        {
            calc.AppendDigit("8");
            DisplayResult();
        }

        private void ButtonDig9_Click(object sender, EventArgs e)
        {
            calc.AppendDigit("9");
            DisplayResult();
        }

        private void ButtonDecPoint_Click(object sender, EventArgs e)
        {
            calc.AppendDigit(".");
            DisplayResult();
        }

        private void ButtonNegate_Click(object sender, EventArgs e)
        {
            calc.Negate();
            DisplayResult();
        }

        
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (calc.CurOperand == "")
            {
                calc.Operation = "+";
                DisplayResult();
                return;
            }

            if(calc.PrevOperand != "") calc.PerformCalculation();
            string curOp = calc.CurOperand;
            if (curOp.Contains("Error"))
            {
                RaiseError();
                return;
            }
            calc.PrevOperand = curOp;
            calc.CurOperand = "";
            calc.Operation = "+";

            DisplayResult();
        }

        private void ButtonSubstract_Click(object sender, EventArgs e)
        {
            if (calc.CurOperand == "")
            {
                calc.Operation = "-";
                DisplayResult();
                return;
            }

            if (calc.PrevOperand != "") calc.PerformCalculation();
            string curOp = calc.CurOperand;
            if (curOp.Contains("Error"))
            {
                RaiseError();
                return;
            }
            calc.PrevOperand = curOp;
            calc.CurOperand = "";
            calc.Operation = "-";

            DisplayResult();
        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            if (calc.CurOperand == "")
            {
                calc.Operation = "*";
                DisplayResult();
                return;
            }

            if (calc.PrevOperand != "") calc.PerformCalculation();
            string curOp = calc.CurOperand;
            if (curOp.Contains("Error"))
            {
                RaiseError();
                return;
            }
            calc.PrevOperand = curOp;
            calc.CurOperand = "";
            calc.Operation = "*";

            DisplayResult();
        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            if (calc.CurOperand == "")
            {
                calc.Operation = "/";
                DisplayResult();
                return;
            }

            if (calc.PrevOperand != "") calc.PerformCalculation();
            string curOp = calc.CurOperand;
            if (curOp.Contains("Error"))
            {
                RaiseError();
                return;
            }
            calc.PrevOperand = curOp;
            calc.CurOperand = "";
            calc.Operation = "/";

            DisplayResult();
        }

        private void ButtonPercent_Click(object sender, EventArgs e)
        {
            calc.percent();
            DisplayResult();
        }

        private void ButtonEqual_Click(object sender, EventArgs e)
        {
            if (calc.CurOperand == "")
            {
                string prevOp = calc.PrevOperand;
                calc.Reset();
                calc.CurOperand = prevOp;
                DisplayResult();
                return;
            }

            if (calc.PrevOperand != "") calc.PerformCalculation();
            string curOp = calc.CurOperand;
            if (curOp.Contains("Error"))
            {
                RaiseError();
                return;
            }
            calc.Reset();
            calc.CurOperand = curOp;

            DisplayResult();
        }

    }

}
