using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightDigitCalculator
{
    class Calculator
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
            CurOperand = "0";
            PrevOperand = "";
            Operation = "";
        }

        private bool IsAppendable()
        {
            bool isNeg = CurOperand.StartsWith("-");
            bool isfrac = CurOperand.Contains(".");

            if (isNeg && isfrac && CurOperand.Length < 10) return true;
            else if (isNeg && CurOperand.Length < 9) return true;
            else if (isfrac && CurOperand.Length < 9) return true;
            else if (CurOperand.Length < 8) return true;

            return false;
        }

        public void AppendDigit(string digit)
        {
            if (!IsAppendable()) return;

            if (CurOperand == "0") CurOperand = "";
            CurOperand += digit;
        }

        public void AppendDecPoint()
        {
            if (CurOperand.Contains(".")) return;
            if (!IsAppendable()) return;

            if (CurOperand == "") CurOperand = "0";
            CurOperand += ".";
        }

        public void Negate()
        {
            if (CurOperand == "" || CurOperand == "0") return;

            if (CurOperand.StartsWith("-"))
            {
                CurOperand = CurOperand.TrimStart('-');
            }
            else CurOperand = "-" + CurOperand;
        }

        public void Percent()
        {
            if (CurOperand == "") return;

            double num = Convert.ToDouble(CurOperand);
            num /= 100.0;
            CurOperand = Convert.ToString(num);
        }

        private string ValidateResult(double result)
        {
            string resultString;
            if (double.IsNaN(result) || double.IsInfinity(result)) throw new Exception(); 
            string num = Convert.ToString(Math.Abs(result));

            string whole = num.Split('.')[0];
            if (whole.Length > 8) throw new Exception();

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

        public void PerformPendingCalculation()
        {
            if (PrevOperand == "") return;
            PerformCalculation();
        }

        public void PerformOperation(string opreator)
        {
            if(CurOperand == "")
            {
                Operation = opreator;
                return;
            }

            PerformPendingCalculation();
            PrevOperand = CurOperand;
            CurOperand = "";
            Operation = opreator;
        }

        public void FinalizeCalculation()
        {
            string result;

            if(CurOperand == "") result = PrevOperand;
            else 
            {
                PerformPendingCalculation();
                result = CurOperand;
            }

            Reset();
            CurOperand = result;
        }
    
    }


}
