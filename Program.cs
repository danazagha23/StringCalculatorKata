using System;


namespace StringCalculatorKata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter string contains from 0 to 2 numbers: ");
            string numbers = Console.ReadLine();

            if(numbers.Count(c => c == ',') > 1)
            {
                throw new Exception("string must has 2 numbers maximum");
            }

            var sc = new StringCalculatorService();
            Console.WriteLine(sc.Add(numbers));
        }
    }
}