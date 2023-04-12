using System;


namespace StringCalculatorKata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter string contains from 0 to 2 numbers: ");
            string numbers = Console.ReadLine();
            string numbers2 = "2\n4,1";

            var sc = new StringCalculatorService();
            Console.WriteLine(sc.Add(numbers));
            Console.WriteLine(sc.Add(numbers2));
        }
    }
}