using System;
using SwapProject;

namespace MainSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nSwap Method Menu:");
                Console.WriteLine("1. Swap integers");
                Console.WriteLine("2. Swap strings");
                Console.WriteLine("0. Exit");
                Console.Write("Select an option: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter first integer: ");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("Enter second integer: ");
                        int b = int.Parse(Console.ReadLine());
                        SwapHelper.Swap(ref a, ref b);
                        break;

                    case "2":
                        Console.Write("Enter first string: ");
                        string str1 = Console.ReadLine();
                        Console.Write("Enter second string: ");
                        string str2 = Console.ReadLine();
                        SwapHelper.Swap(ref str1, ref str2);
                        break;

                    case "0":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
