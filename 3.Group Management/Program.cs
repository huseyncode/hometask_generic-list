using System;
using _3.Group_Management;
namespace MainGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            GroupManager groupManager = new GroupManager();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nGroup Management Menu:");
                Console.WriteLine("1. Add Group");
                Console.WriteLine("2. List Groups");
                Console.WriteLine("0. Exit");
                Console.Write("Select an option: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter group name: ");
                        string groupName = Console.ReadLine();
                        groupManager.AddGroup(groupName);
                        break;

                    case "2":
                        Console.WriteLine("Groups:");
                        groupManager.ListGroups();
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

