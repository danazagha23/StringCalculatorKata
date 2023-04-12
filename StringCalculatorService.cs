using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata
{
    public class StringCalculatorService
    {
        public char[] Delimiter { get; set; } = {',', '\n'}; 
        public int Add(string numbers)
        {
            if (numbers.Length == 0) return 0;

            if(numbers.Substring(0, 2) == "//")
            {
                Delimiter = new char[] { numbers[2] };
                numbers = numbers.Substring(4);
            }

            string[] ints = numbers.Split(Delimiter);

            bool existNegativeNumbers = false;
            List<int> negativeNums = new List<int>();
            int sum = 0;
            foreach (string s in ints)
            {
                int num = Convert.ToInt32(s);
                existNegativeNumbers = num < 0 ? true : false;
                if (existNegativeNumbers)
                {
                    negativeNums.Add(num);
                }
                sum += num <= 1000 ? num : 0;
            }
            if (negativeNums.Count > 0)
            {
                string exception = "negatives not allowed: ";
                foreach (int i in negativeNums)
                {
                    exception = exception + i.ToString();
                }
                throw new Exception(exception);
            }
            return sum;
        }
    }
}
