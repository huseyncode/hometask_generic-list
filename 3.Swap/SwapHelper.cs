using System;

namespace SwapProject
{
    public static class SwapHelper
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"Swapped values: {a}, {b}");
        }
    }
}
