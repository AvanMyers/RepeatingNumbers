using System;

namespace RepeatingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrayMass = 30;
            int checkNumber = 0;
            int checkRepeat = 1;
            int pinCheckRepeat = 1;
            int minRandom = 0;
            int maxRandom = 10;
            Random random = new Random();

            int[] array = new int[arrayMass];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minRandom, maxRandom);
            }

            foreach (int number in array)
            {
                Console.Write(number + " ");
            }

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    checkRepeat++;

                    if (checkRepeat >= pinCheckRepeat)
                    {
                        checkNumber = array[i];
                        pinCheckRepeat = checkRepeat;
                    }
                }
                else
                {
                    checkRepeat = 1;
                }

            }

            Console.Write($" :число {checkNumber} повторяется {pinCheckRepeat} раза подряд");
            Console.ReadKey();
        }
    }
}
