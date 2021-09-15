using System;

namespace FindValueMinMax
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Write a program to accept three integer number and find maximum number from three integer.
            int[] array = new int[3];
            for (var i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter number {0}: ", i + 1);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            var max = array[0];
            for (var i = 0; i < 3; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            Console.WriteLine("Max number is: {0}", max);
        }
    }
}