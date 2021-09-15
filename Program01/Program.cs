using System;
using System.Runtime.InteropServices;

namespace Program01
{
    internal class Program
    {
        public static void Main(string[] args)
        {
                //Write a program to enter: name, address, phone and display these information.
                Console.WriteLine("Enter name: ");
                var name = Console.ReadLine();
                Console.WriteLine("Enter address: ");
                var address = Console.ReadLine();
                Console.WriteLine("Enter phone number:");
                var phoneNumber = Console.ReadLine();
                Console.WriteLine("Name: {0}\nAddress: {1}\nPhone number: {2}", name, address, phoneNumber);
        }
    }
}