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
            
            int sum = 0;
            foreach (string s in ints)
            {
                sum += Convert.ToInt32(s);
            }
            return sum;
        }
    }
}
