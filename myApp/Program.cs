using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number");
            int num1= Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            string operand;
            Console.Write("what would you like to do with these numbers? +-/*");
            operand = Console.ReadLine();
            if(operand == "+") {
                int sum = num1 + num2;
                Console.WriteLine($"The sum of the two is {sum}");
            }
            if(operand== "-"){
                int sub = num1 - num2;
                Console.WriteLine($"The sum of this substraction is {sub}");
            }
            if(operand== "*"){
                int mup = num1 * num2;
                Console.WriteLine($"When you multiply these two numbers you get {mup}");
            }
            if(operand == "/"){
                int div = num1/num2;
                Console.WriteLine($"When you divide the two numbers the sum is {div}");
            }




        }
    }
}