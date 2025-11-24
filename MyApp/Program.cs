using System;

namespace MyApp
{
    public class Calculator
    {
        public int Add(int a, int b) => a + b;
        public int Subtract(int a, int b) => a - b;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            Console.WriteLine($"2 + 3 = {calc.Add(2, 3)}");
            Console.WriteLine($"5 - 2 = {calc.Subtract(5, 2)}");
        }
    }
}