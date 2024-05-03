using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Services
{
    public class CalculatorImp
    {

        private List<string> historicList;
        private string data;

        public CalculatorImp(string data)
        {
            historicList = new List<string>();
            this.data = data;
        }

        public int Sum(int num1, int num2)
        {
            int result = num1 + num2;
            historicList.Insert(0, "Result = " + result + data);

            return result;
        }

        public int Subtract(int num1, int num2)
        {
            int result = num1 - num2;
            historicList.Insert(0, "Result = " + result + data);

            return result;
        }

        public int Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            historicList.Insert(0, "Result = " + result + data);

            return result;
        }

        public int Divide(int num1, int num2)
        {
            int result = num1 / num2;
            historicList.Insert(0, "Result = " + result + data);

            return result;
        }

        public List<string> historic()
        {
            historicList.RemoveRange(3, historicList.Count - 3);
            return historicList;
        }
    }
}