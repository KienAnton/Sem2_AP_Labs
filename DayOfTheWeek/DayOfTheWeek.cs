using System;

namespace DayOfTheWeek
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Write a program that accepts a number between 1 and 7 from the user and 
            //return the corresponding day of the week(1- Monday, 2- Tuesday and so on).
            Console.WriteLine("Enter a number between 1 and 7: ");
            var number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}