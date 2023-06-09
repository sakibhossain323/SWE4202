using System;

namespace EightDigitCalculator
{
    public class Calculator
    {
        public string CurOperand { get; set; }
        public string PrevOperand { get; set; }
        public string Operation { get; set; }

        public Calculator()
        {
            this.Reset();
        }

        public void Reset()
        {
            this.CurOperand = "0";
            this.PrevOperand = "";
            this.Operation = "";
        }

        private bool FitDigitlimit()
        {
            if (CurOperand.StartsWith("-"))
            {
                if (CurOperand.Contains(".") && CurOperand.Length < 10) return true;
                else if (CurOperand.Length < 9) return true;
                return false;
            }
            else
            {
                if (CurOperand.Contains(".") && CurOperand.Length < 9) return true;
                else if (CurOperand.Length < 8) return true;
                return false;
            }
        }

        private bool Appendable(string digit)
        {
            if (digit == "0" && CurOperand == "0") return false;
            else if (digit == "." && CurOperand.Contains(".")) return false;

            return FitDigitlimit();
        }
        public void AppendDigit(string digit)
        {
            if (!Appendable(digit)) return;

            if (digit == "." && CurOperand == "") CurOperand = "0";
            else if (digit != "." && CurOperand == "0") CurOperand = "";

            CurOperand += digit;
        }

        public void Negate()
        {
            if (CurOperand.Contains("Error")) return;
            else if (CurOperand == "0" || CurOperand == "") return;
            else if (CurOperand.StartsWith("-"))
            {
                CurOperand = CurOperand.TrimStart('-');
            }
            else CurOperand = "-" + CurOperand;
        }

        private string ValidateResult(double result)
        {
            string resultString = "Error";
            if (double.IsNaN(result) || double.IsInfinity(result)) return resultString;
            string num = Convert.ToString(Math.Abs(result));

            string whole = num.Split('.')[0];
            if (whole.Length > 8) return resultString;

            if (num.Contains(".")) result = Math.Round(result, 8 - whole.Length);
            resultString = Convert.ToString(result);

            return resultString;
        }

        public void PerformCalculation()
        {
            if (Operation == "") return;

            double num1 = Convert.ToDouble(PrevOperand);
            double num2 = Convert.ToDouble(CurOperand);
            double result = 0;
            
            if (Operation == "+") result = num1 + num2;
            else if (Operation == "-") result = num1 - num2;
            else if (Operation == "*") result = num1 * num2;
            else if (Operation == "/") result = num1 / num2;

            CurOperand = ValidateResult(result);
        }

        public void percent()
        {
            if (CurOperand.Contains("Error")) return;
            else if (CurOperand == "") return;
            {
                double num = Convert.ToDouble(CurOperand);
                num /= 100.0;
                CurOperand = Convert.ToString(num);
            }
        }
    }
}
