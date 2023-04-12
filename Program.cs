using System;


namespace StringCalculatorKata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter string of numbers: ");
            string numbers = "//;\n4;1002;7";

            var sc = new StringCalculatorService();

            Console.WriteLine(sc.Add(numbers));
        }
    }
}