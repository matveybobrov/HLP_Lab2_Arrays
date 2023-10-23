using System;
using System.Linq;

// Перемножение матриц			
public class Task5
{
    public static void Main()
    {
        Console.WriteLine("Введите число строк и столбцов матрицы:");
        int size = Convert.ToInt16(Console.ReadLine());
        Random rnd = new Random();
        byte[] matrix1 = new byte[size*size];
        byte[] matrix2 = new byte[size*size];
        int[] result = new int[size*size];

        for (int i = 0; i < size*size; i++)
        {
            matrix1[i] = Convert.ToByte(rnd.Next(2, 4));
            matrix2[i] = Convert.ToByte(rnd.Next(2, 4));
        }
        Console.WriteLine("Матрица 1:\n[{0}]", string.Join(", ", matrix1));
        Console.WriteLine("Матрица 2:\n[{0}]", string.Join(", ", matrix2));

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                for (int k = 0; k < size; k++)
                {
                    result[i * size + j] += matrix1[i * size + k] * matrix2[k * size + j];
                }
            }
        }

        Console.WriteLine("Результат:\n[{0}]", string.Join(", ", result));
    }
}