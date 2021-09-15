using System;

namespace MultiplicationTable
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            var n = Convert.ToInt32(Console.ReadLine());
            for (var i = 1; i < 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", n, i, n*i);
            }
        }
    }
}