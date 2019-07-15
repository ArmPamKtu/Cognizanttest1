using System;

namespace Consoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            var math = new Math();
            int num1, num2;

            Console.WriteLine($"please enter two numbers");

            input = Console.ReadLine();
            Int32.TryParse(input, out num1);

            input = Console.ReadLine();
            Int32.TryParse(input, out num2);

            var sum = math.Sum(num1, num2);
            Console.WriteLine($"{num1} + {num2} = {sum}");

            var substract = math.Substract(num1, num2);
            Console.WriteLine($"{num1} + {num2} = {substract}");

            //var myConst = Math.myConstant;
            //DateTime time = DateTime.Now;
        }
    }
}