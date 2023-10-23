using System;

// Задача - вставить элементы в массив с определённой позиции

namespace Task1
{
    public class Task1
    {
        public static void Main()
        {
            Random rnd = new Random();

            Console.WriteLine("Введите размер оригинального массива");
            int size = Convert.ToInt16(Console.ReadLine());

            int[] initialArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                initialArray[i] = rnd.Next(0, 10);
            }

            Console.Write("Изначальный массив: ");
            Console.WriteLine("[{0}]", string.Join(", ", initialArray));

            Console.WriteLine("Сколько элементов вы хотите вставить в массив?");
            int count = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Начиная с какой позиции вы хотите вставить эти элементы в массив?");
            int pos = Convert.ToInt16(Console.ReadLine());

            var finalArray = new int[size + count];
            Array.Copy(initialArray, 0, finalArray, 0, pos);
            for (int i = pos; i < pos + count; i++)
            {
                finalArray[i] = rnd.Next(0, 10);
            }
            Array.Copy(initialArray, pos, finalArray, pos + count, size - pos);

            Console.WriteLine("Результат:");
            Console.WriteLine("[{0}]", string.Join(", ", finalArray));
        }
    }
}