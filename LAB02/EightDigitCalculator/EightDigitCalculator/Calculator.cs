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
            this.Reset(); // Initializes properties
        }

        public void Reset() // Resets Calculator to intial state
        {
            CurOperand = "0";
            PrevOperand = "";
            Operation = "";
        }

        private bool IsAppendable() // Checks if a new digit can be appended
        {
            bool isNeg = CurOperand.StartsWith("-"); // Checks if a negative number
            bool isfrac = CurOperand.Contains("."); // Checks if fractional number

            if (isNeg && isfrac && CurOperand.Length < 10) return true; // Less than 8 digit including - and . symbol
            else if (isNeg && CurOperand.Length < 9) return true; // Less than 8 digit including - symbol
            else if (isfrac && CurOperand.Length < 9) return true; //Less than 8 digit including . symbol
            else if (CurOperand.Length < 8) return true;

            return false;
        }

        public void AppendDigit(string digit)
        {
            if (!IsAppendable()) return; // Already 8 digit

            if (CurOperand == "0") CurOperand = ""; // Avoids Leading Zeroes
            CurOperand += digit;
        }

        public void AppendDecPoint() // Appends Decimal Point
        {
            if (CurOperand.Contains(".")) return; // Prevents multiple decimal point symbols
            if (!IsAppendable()) return; // Prevents appending if 8 digits already exist

            if (CurOperand == "") CurOperand = "0"; // Puts a Leading zero before decimal point
            CurOperand += ".";
        }

        public void Negate()
        {
            if (CurOperand == "" || CurOperand == "0") return; // Prevents Negating empty or zero value

            if (CurOperand.StartsWith("-"))
            {
                CurOperand = CurOperand.TrimStart('-'); // Makes a negative number positive
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

        private string ValidateResult(double result) // Prevents Invalid Results
        {
            if (double.IsNaN(result) || double.IsInfinity(result)) throw new Exception();
            
            string num = Convert.ToString(Math.Abs(result));
            string whole = num.Split('.')[0]; // Takes integer portion of the number
            if (whole.Length > 8) throw new Exception(); // Prevents Exceeding 8 digit limit
            if (num.Contains(".")) result = Math.Round(result, 8 - whole.Length); // Rounds up floating point values to 8 digits

            string resultString = Convert.ToString(result);
            return resultString;
        }

        private void PerformCalculation()
        {
            if (PrevOperand == "" || Operation == "") return; // Prevents invalid operation

            double num1 = Convert.ToDouble(PrevOperand);
            double num2 = Convert.ToDouble(CurOperand);
            double result = 0;

            if (Operation == "+") result = num1 + num2;
            else if (Operation == "-") result = num1 - num2;
            else if (Operation == "*") result = num1 * num2;
            else if (Operation == "/") result = num1 / num2;

            CurOperand = ValidateResult(result);
        }

        public void PerformOperation(string opreator)
        {
            if(CurOperand == "") // Prevents invalid operation
            {
                Operation = opreator;
                return;
            }

            PerformCalculation(); // Performs previous pending operations
            PrevOperand = CurOperand;
            CurOperand = "";
            Operation = opreator;
        }

        public void FinalizeCalculation() // Calculates final result on pressing Equal button
        {
            string result;

            if(CurOperand == "") result = PrevOperand;
            else 
            {
                PerformCalculation();
                result = CurOperand;
            }

            Reset();
            CurOperand = result;
        }
    
    }

}
