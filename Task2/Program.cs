using System;

// Задача - поменять местами первую и вторую половины массива

namespace Task2
{
    public class Task2
    {
        public static void Main()
        {
            Random rnd = new Random();
            Console.WriteLine("Введите размер массива");
            int size = Convert.ToInt16(Console.ReadLine());

            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = rnd.Next(0, 10);
            }
            Console.WriteLine("[{0}]", string.Join(", ", array));
            for (int i = 0; i < size / 2 + size % 2; i++)
            {
                int tmp = array[size/2 + i];
                array[size/2 + i] = array[i];
                array[i] = tmp;
            }

            Console.WriteLine("[{0}]", string.Join(", ", array));
        }
    }
}
