using EmirsLibrary.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Metoder_Opgave
{
    class Program
    {
        static void Main(string[] args)
        {
            Opgave1();
            Opgave2();
            Opgave3();
            Opgave4();
            Opgave5();
            Opgave6();
            Opgave7();
            Opgave8();
            Opgave9();
            Opgave10();
            Opgave11();
        }

        static void Continue()
        {
            Console.WriteLine("\r\nPress any key to continue.");
            Console.ReadKey();
            Console.Clear();
        }

        static void Opgave1()
        {
            "Opgave 1: ".WriteLine();

            int tal1 = ConsoleEx.GetInput<int>("Indtast tal 1: ").AndClear();
            int tal2 = ConsoleEx.GetInput<int>("Indtast tal 2: ").AndClear();

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

        static void Opgave2()
        {
            "Opgave 2: ".WriteLine();

            int tal1 = ConsoleEx.GetInput<int>("Indtast tal 1: ").AndClear();
            int tal2 = ConsoleEx.GetInput<int>("Indtast tal 2: ").AndClear();

            double tal3 = Math.Sqrt(Math.Pow(tal1, 2) + Math.Pow(tal2, 2));

            Console.WriteLine($"c = {tal3}\r\n" + // 2.1
                $"Bigger Number: {(tal1 != tal2 ? tal1 > tal2 ? "First" : "Second" : "Neither")}"); // 2.2

            Continue();
        }

        static void Opgave3()
        {
            "Opgave 3: ".WriteLine();

            string name = ConsoleEx.GetInput<string>("Indtast dit navn: ").AndClear();
            int age = ConsoleEx.GetInput<int>("Indtast din alder: ").AndClear();

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
            "Opgave 4: ".WriteLine();

            for (int i = 0; i < 10; i++)
                Console.Write(i + 1 + " ");

            Continue();
        }

        static void Opgave5()
        {
            "Opgave 5: ".WriteLine();

            for (int i = 10; i > 0; i--)
                Console.Write(i + " ");

            Continue();
        }

        static void Opgave6()
        {
            "Opgave 6".WriteLine();

            int number = ConsoleEx.GetInput<int>("Indtast et tal: ").AndClear();

            for (int i = 0; i < 32; i++)
                Console.WriteLine(number++);
            for (int i = 0; i < 16; i++)
                Console.WriteLine(number--);

            Continue();
        }

        static void Opgave7()
        {
            "Opgave 7: ".WriteLine();

            int[] arr = new int[9];

            for (int i = 0; i < arr.Length; i++)
                arr[i] = i + 1;

            for (int i = 0; i < 5; i++) // why loop?
                if (i != 4)
                    continue;
                else
                    arr[i] = arr[i - 1] * 2;

            foreach (var item in arr)
                Console.WriteLine(item);

            Continue();
        }

        static void Opgave8()
        {
            "Opgave 8: ".WriteLine();

            List<int> listeB = new List<int>();

            for (int i = 0; i < 20; i++)
                if ((i + 1) % 2 == 0)
                    listeB.Add(i + 1);

            listeB.Where(n => n % 3 == 0).ToList().ForEach(a => listeB.Remove(a)); // ToList to make a copy, can't iterate through list and remove at the same time

            listeB[2] = 17;

            var listeA = listeB.ToList();
            listeA.Reverse();

            foreach (var item in listeB)
                item.WriteLine();

            foreach (var item in listeA)
                item.WriteLine();

            Continue();
        }

        static void Opgave9()
        {
            "Opgave 9: ".WriteLine();

            Random random = new Random();

            int[] lottoNumbers = new int[7];
            for (int i = 0; i < lottoNumbers.Length; i++)
                lottoNumbers[i] = random.Next(1, 20);

            int[] userNumbers = ConsoleEx.GetInput<int[]>("Lotto numbers has been generated, make your guess as to what it is!", 7);

            int correct = 0;

            for (int i = 0; i < 7; i++)
                if (userNumbers[i] == lottoNumbers[i])
                    correct++;

            if (correct > 2)
                Console.WriteLine($"You had {correct} correct guesses and have gained {(correct * (correct * 20))} points!");
            else
                Console.WriteLine("You did not guess enough lotto numbers correctly, therefore you get nothing.");

            Continue();
        }

        static void Opgave10()
        {
            "Opgave 10: ".WriteLine();

            int secretNumber = new Random().Next(20);

            int guess = -1;
            int amountOfGuesses = 0;

            Console.WriteLine("A random number between 1 and 20 has been generated. Try guessing it!");
            while ((guess = ConsoleEx.GetInput<int>("Your guess: ")) != secretNumber)
            {
                if (secretNumber < guess)
                    Console.WriteLine("Wrong, try guessing lower.");
                else
                    Console.WriteLine("Wrong, try guessing higher.");

                amountOfGuesses++;
            }

            Console.WriteLine($"Congratulations, you guessed correctly! The number was {secretNumber}!");
            if (amountOfGuesses > 7)
                Console.WriteLine("Sadly it took you too many guesses for you to win a prize.");
            else
            {
                Console.WriteLine("You won a car!");
                Console.WriteLine(@" /|_||_\`.__");
                Console.WriteLine(@"(   _    _ _\");
                Console.WriteLine(@"=`-(_)--(_)-'  hjw");
                Console.WriteLine("Credits to Hayley Jane Wakenshaw for the art.");
            }

            Continue();
        }

        static void Opgave11()
        {
            "Opgave 11: ".WriteLine();

            Sum(1, 11).WriteLine();
            Div(7, 2).WriteLine();
            Rem(19, 200).WriteLine();
            List<int> list = new List<int>();
            Random random = new Random();
            for (int i = 0; i < random.Next(10); i++)
                list.Add(random.Next(42));
            GetHighestElement(list).WriteLine();
            Indeholder(list, 42).WriteLine();
            GetAverage(list).WriteLine();
            IsSorted(list).WriteLine();
            list.Sort();
            IsSorted(list).WriteLine();

        }

        static int Sum(int a, int b) => a + b;
        static double Div(int a, int b) => a / b;
        static double Rem(int a, int b) => b / a;
        static T GetHighestElement<T>(List<T> list) => list.Max();
        static bool Indeholder<T>(List<T> list, T item) => list.Contains(item);

        static int GetAverage(List<int> list)
        {
            int average = 0;
            foreach (int value in list)
                average += value;
            average /= list.Count;
            return average;
        }

        static bool IsSorted(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
                if (i != 0)
                    if (list[i - 1] > list[i])
                        return false;

            return true;
        }
    }
}
