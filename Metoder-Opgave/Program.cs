using EmirsLibrary.Extensions;
using System;

namespace Metoder_Opgave
{
    class Program
    {
        static void Main(string[] args)
        {
            Opgave1(ConsoleEx.GetInput<int>("Indtast tal 1: ").AndClear(), ConsoleEx.GetInput<int>("Indtast tal 2: ").AndClear());
            Opgave2(ConsoleEx.GetInput<int>("Indtast tal 1: ").AndClear(), ConsoleEx.GetInput<int>("Indtast tal 2: ").AndClear());
            Opgave3(ConsoleEx.GetInput<string>("Indtast dit navn: ").AndClear(), ConsoleEx.GetInput<int>("Indtast din alder: ").AndClear());
            Opgave4();
        }

        static void Continue()
        {
            Console.WriteLine("\r\nPress any key to continue.");
            Console.ReadKey();
            Console.Clear();
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

            Continue();
        }

        static void Opgave2(int tal1, int tal2)
        {
            "Opgave 2: ".WriteLine();

            double tal3 = Math.Sqrt(Math.Pow(tal1, 2) + Math.Pow(tal2, 2));

            Console.WriteLine($"c = {tal3}\r\n" + // 2.1
                $"Bigger Number: {(tal1 != tal2 ? tal1 > tal2 ? "First" : "Second" : "Neither")}"); // 2.2

            Continue();
        }

        static void Opgave3(string name, int age)
        {
            if (age < 3)
                Console.WriteLine($"{name}, du må gå med ble"); // 3.1
            else if (age >= 3 && age <= 15)
                Console.WriteLine($"{name}, du må ingenting"); // 3.2
            else if (age > 15 && age < 18)
                Console.WriteLine($"{name}, du må drikke"); // 3.3
            else if (age > 18)
                Console.WriteLine($"{name}, du må stemme og køre bil"); // 3.4

            Continue();
        }

        static void Opgave4()
        {
            for (int i = 0; i < 10; i++)
                Console.Write(i + 1 + " ");

            Continue();
        }
    }
}
