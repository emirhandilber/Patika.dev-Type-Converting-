using System;

namespace TRYIT
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 30;
            sbyte number2 = 10;
            int number3 = 5;
            
            int d = number1 + number2 + number3;
            Console.WriteLine("d = " + d);

            Console.WriteLine("Bilinçli hali");

            int x =5;
            byte y= (byte)x;

            Console.WriteLine("to string metodu");
            int e = 1;
            string ee = e.ToString();

            Console.WriteLine("Parse metodu");
            string rakam1 = "10";
            int rakam11 = Int32.Parse(rakam1);
        }
    }
}