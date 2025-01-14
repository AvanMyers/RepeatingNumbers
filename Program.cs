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
            int pinRepeatNumber = 0;
            int pinCheckRepeat = 1;
            int minRandom = 0;
            int maxRandom = 10;
            Random random = new Random();

            int[] array = new int[arrayMass];

            for (int i = 1; i < array.Length; i++)
            {
                array[i] = random.Next(minRandom, maxRandom);
                Console.Write(array[i] + " ");

                if (array[i] != array[0] && array[i] == array[i - 1])
                {
                    checkNumber = array[i];
                    checkRepeat++;
                }
                else if (checkRepeat >= pinCheckRepeat)
                {
                    pinRepeatNumber = checkNumber;
                    pinCheckRepeat = checkRepeat;
                    checkRepeat = 1;
                }
            }

            Console.Write($" :число {pinRepeatNumber} повторяется {pinCheckRepeat} раза подряд");
            Console.ReadKey();
        }
    }
}
