namespace Tydz4_cw1_ParzystaNieparzysta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj proszę dowolną liczbę całkowitą:");
            int inputNumber = GetNumber();

            if (inputNumber % 2 != 0)
                Console.WriteLine("Podana liczba jest liczbą nieparzystą.");
            else
                Console.WriteLine("Podana liczba jest liczbą parzystą.");
        }

        private static int GetNumber()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Podana liczba nie jest liczbą całkowitą o dopuszczalnym zakresie. Wprowadź liczbę jeszcze raz:");
                    continue;
                }
                else
                    return number;
            }
        }
    }
}