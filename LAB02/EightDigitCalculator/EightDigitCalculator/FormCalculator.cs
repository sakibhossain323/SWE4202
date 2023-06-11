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
    public partial class FormCalculator : Form
    {
        readonly Calculator calc = new Calculator(); // Instantiating Calculator Object
        
        public FormCalculator()
        {
            InitializeComponent();
            DisplayResult(); // Displaying Initial state of Calculator
        }

        private void DisplayResult() // Updates results on UI
        {
            LabelResult.Text = calc.CurOperand;
            LabelPrevResult.Text = calc.PrevOperand + " " + calc.Operation;
        }

        private void EnableButtons() // Enables all buttons
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button button) button.Enabled = true;
            }
        }

        private void DisableButtons() // Disables all buttons except AC button
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button button) button.Enabled = false;
            }

            ButtonAC.Enabled = true; 
        }

        private void DisplayError() // Show Error Message
        {
            calc.Reset();
            DisplayResult();
            LabelResult.Text = "Error: Press AC";
            DisableButtons();
        }

        private void ButtonAC_Click(object sender, EventArgs e)
        {
            calc.Reset();
            DisplayResult();
            EnableButtons();
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
            calc.AppendDecPoint();
            DisplayResult();
        }

        private void ButtonNegate_Click(object sender, EventArgs e)
        {
            calc.Negate();
            DisplayResult();
        }

        private void ButtonPercent_Click(object sender, EventArgs e)
        {
            calc.Percent();
            DisplayResult();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                calc.PerformOperation("+");
                DisplayResult();
            }
            catch (Exception) { DisplayError(); }
        }

        private void ButtonSubstract_Click(object sender, EventArgs e)
        {
            try
            {
                calc.PerformOperation("-");
                DisplayResult();
            }
            catch (Exception) { DisplayError(); }
        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                calc.PerformOperation("*");
                DisplayResult();
            }
            catch (Exception) { DisplayError(); }
        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            try
            {
                calc.PerformOperation("/");
                DisplayResult();
            }
            catch (Exception) { DisplayError(); }
        }

        private void ButtonEqual_Click(object sender, EventArgs e)
        {
            try
            {
                calc.FinalizeCalculation();
                DisplayResult();
            }
            catch (Exception) { DisplayError(); }
        }

    }

}
