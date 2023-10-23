using System;

// Поиск свободных мест в кинотеатре
public class Task4
{
    public static int countFreeSpaces(int[,] cinema, int n, int m, int k)
    {
        for (int i = 0; i < n; i++)
        {
            int freeSpaces = 0;
            for (int j = 0; j < m; j++)
            {
                if (cinema[i, j] == 0)
                {
                    freeSpaces++;
                }
                else
                {
                    freeSpaces = 0;
                }
                if (freeSpaces == k)
                {
                    return i + 1;
                }
            }
        }
        return -1;
    }

    public static void Main()
    {
        Random rnd = new Random();

        Console.WriteLine("Введите количество рядов: ");
        int n = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Введите количество мест в каждом ряду: ");
        int m = Convert.ToInt16(Console.ReadLine());
        int[,] cinema = new int[n, m];

        Console.WriteLine("Места в кинотеатре: ");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                cinema[i, j] = rnd.Next(0, 2);
                Console.Write(cinema[i, j]);
            }
            Console.Write("\n");
        }

        Console.WriteLine("Сколько мест подряд нужно забронировать?");
        int k = Convert.ToInt16(Console.ReadLine());

        int row = countFreeSpaces(cinema, n, m, k);
        if (row == -1)
        {
            Console.WriteLine($"Ни в одном ряду нет {k} идущих подряд свободных мест");
        }
        else
        {
            Console.WriteLine($"В ряду {row} есть {k} идущих подряд свободных мест");
        }
    }
}
