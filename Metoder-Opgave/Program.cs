using EmirsLibrary.Extensions;
using System;

namespace Metoder_Opgave
{
    class Program
    {
        static void Main(string[] args)
        {
            int tal1 = ConsoleEx.GetInput<int>().AndClear();
            int tal2 = ConsoleEx.GetInput<int>().AndClear();

            Opgave1(tal1, tal2);
        }

        static void Opgave1(int tal1, int tal2)
        {
            "Opgave 1: ".WriteLine();

            int add = tal1 + tal2;
            int div1 = tal1 / tal2;
            float div2 = tal1 / tal2;
            int rem = tal2 / tal1;
            double pow = Math.Pow(tal1, tal2);

            Console.WriteLine($"Addition: {add}\r\n" + // 1.1
                $"Division (Int): {div1}\r\n" + // 1.2
                $"Division (Float): {div2}\r\n" + // 1.2
                $"Rem: {rem}\r\n" + // 1.3
                $"Pow: {pow}"); // 1.4
        }
    }
}
