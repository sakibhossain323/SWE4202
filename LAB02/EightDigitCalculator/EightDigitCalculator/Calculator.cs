using System;

namespace EightDigitCalculator
{
    public class Calculator
    {
        private string curOperand, prevOperand, operation;
        public Calculator()
        {
            curOperand = "0";
            prevOperand = "";
            operation = "";
        }

        public void Reset()
        {
            curOperand = "0";
            prevOperand = "";
            operation = "";
        }

        public string GetCurOperand()
        {
            return curOperand;
        }

        public string GetPrevOperand()
        {
            return prevOperand;
        }

        public string GetOperation()
        {
            return operation;
        }

        public void SetCurOperand(string operand)
        {
            curOperand = operand;
        }

        public void SetPrevOperand(string operand)
        {
            double num = Convert.ToDouble(operand);
            prevOperand = Convert.ToString(num);
        }

        public void SetOperation(string operationSymbol)
        {
            operation = operationSymbol;
        }

        private bool FitDigitlimit()
        {
            if (curOperand.StartsWith("-"))
            {
                if (curOperand.Contains(".") && curOperand.Length < 10) return true;
                else if (curOperand.Length < 9) return true;
                return false;
            }
            else
            {
                if (curOperand.Contains(".") && curOperand.Length < 9) return true;
                else if (curOperand.Length < 8) return true;
                return false;
            }
        }

        private bool Appendable(string digit)
        {
            if (digit == "0" && curOperand == "0") return false;
            else if (digit == "." && curOperand.Contains(".")) return false;

            return FitDigitlimit();
        }
        public void AppendDigit(string digit)
        {
            if (!Appendable(digit)) return;

            if (digit == "." && curOperand == "") curOperand = "0";
            else if (digit != "." && curOperand == "0") curOperand = "";

            curOperand += digit;
        }

        public void Negate()
        {
            if (curOperand.Contains("Error")) return;
            else if (curOperand == "0" || curOperand == "") return;
            else if (curOperand.StartsWith("-"))
            {
                curOperand = curOperand.TrimStart('-');
            }
            else curOperand = "-" + curOperand;
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
            if (operation == "") return;

            double num1 = Convert.ToDouble(prevOperand);
            double num2 = Convert.ToDouble(curOperand);
            double result = 0;
            
            if (operation == "+") result = num1 + num2;
            else if (operation == "-") result = num1 - num2;
            else if (operation == "*") result = num1 * num2;
            else if (operation == "/") result = num1 / num2;

            curOperand = ValidateResult(result);
        }

        public void percent()
        {
            if (curOperand.Contains("Error")) return;
            else if (curOperand == "") return;
            {
                double num = Convert.ToDouble(curOperand);
                num /= 100.0;
                curOperand = Convert.ToString(num);
            }
        }
    }
}
