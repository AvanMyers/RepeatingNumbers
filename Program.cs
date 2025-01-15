using System;

namespace RepeatingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 30;
            int repitingNumber = 0;
            int countOfRepit = 1;
            int maxCountOfRepit = 1;
            int minRandom = 0;
            int maxRandom = 10;
            Random random = new Random();

            int[] numbers = new int[size];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minRandom, maxRandom);
            }

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    countOfRepit++;

                    if (countOfRepit >= maxCountOfRepit)
                    {
                        repitingNumber = numbers[i];
                        maxCountOfRepit = countOfRepit;
                    }
                }
                else
                {
                    countOfRepit = 1;
                }

            }

            Console.Write($" :число {repitingNumber} повторяется {maxCountOfRepit} раза подряд");
            Console.ReadKey();
        }
    }
}
