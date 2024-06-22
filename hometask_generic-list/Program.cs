using System;
using CustomListProject;

namespace MainCustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> customList = new CustomList<int>();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nCustomList Menu:");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Remove");
                Console.WriteLine("3. Contains");
                Console.WriteLine("4. Any");
                Console.WriteLine("5. Clear");
                Console.WriteLine("6. FirstOrDefault");
                Console.WriteLine("7. ElementAtOrDefault");
                Console.WriteLine("8. LastOrDefault");
                Console.WriteLine("9. GetAll");
                Console.WriteLine("0. Exit");
                Console.Write("Select an option: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter item to add: ");
                        int addItem = int.Parse(Console.ReadLine());
                        customList.Add(addItem);
                        Console.WriteLine("Item added.");
                        break;

                    case "2":
                        Console.Write("Enter item to remove: ");
                        int removeItem = int.Parse(Console.ReadLine());
                        customList.Remove(removeItem);
                        Console.WriteLine("Item removed.");
                        break;

                    case "3":
                        Console.Write("Enter item to check if contains: ");
                        int containsItem = int.Parse(Console.ReadLine());
                        Console.WriteLine("Contains: " + customList.Contains(containsItem));
                        break;

                    case "4":
                        Console.WriteLine("Any: " + customList.Any());
                        break;

                    case "5":
                        customList.Clear();
                        Console.WriteLine("List cleared.");
                        break;

                    case "6":
                        Console.WriteLine("FirstOrDefault: " + customList.FirstOrDefault());
                        break;

                    case "7":
                        Console.Write("Enter index: ");
                        int index = int.Parse(Console.ReadLine());
                        Console.WriteLine("ElementAtOrDefault: " + customList.ElementAtOrDefault(index));
                        break;

                    case "8":
                        Console.WriteLine("LastOrDefault: " + customList.LastOrDefault());
                        break;

                    case "9":
                        Console.WriteLine("Items: " + string.Join(", ", customList.GetAll()));
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
