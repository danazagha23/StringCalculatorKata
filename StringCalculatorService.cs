using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata
{
    public class StringCalculatorService
    {
        public int Add(string numbers)
        {
            if (numbers.Length == 0) return 0;

            string[] ints = numbers.Split(new char[] { ',', '\n' });

            int sum = 0;

            foreach (string s in ints)
            {
                sum += Convert.ToInt32(s);
            }

            return sum;
        }
    }
}
