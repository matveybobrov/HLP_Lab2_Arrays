using System;
using System.Linq;

// Операции над массивами
public class Task3
{
    public static int[] GenerateArray()
    {
        Random rnd = new Random();

        Console.WriteLine("Введите размер массива: ");
        int size = Convert.ToInt16(Console.ReadLine());
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = rnd.Next(0, size);
        }

        return arr;
    }

    public static void PrintArray(int[] arr)
    {
        Console.WriteLine(string.Join(", ", arr));
    }

    public static int[] SumArrays(int[] arr1, int[] arr2)
    {
        if (arr1.Length != arr2.Length)
        {
            Console.WriteLine("Массивы должны быть одинаковой длины для сложения");
            return new int[0];
        }
        int[] newArray = new int[arr1.Length];
        for (int i = 0; i < arr1.Length; i++)
        {
            newArray[i] = arr1[i] + arr2[i];
        }
        return newArray;
    }

    public static int[] SortArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length - 1 - i; j++)
            {
                if (arr[j] < arr[j + 1])
                {
                    int tmp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = tmp;
                }
            }
        }
        return arr;
    }

    public static int[] MultiplyArrayByNumber(int[] arr, int number)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] *= number;
        }
        return arr;
    }

    public static int[] FindMatchingValues(int[] arr1, int[] arr2)
    {
        int[] duplicates = Array.FindAll(arr1, element => arr2.Contains(element));
        return duplicates.Distinct().ToArray();
    }


    public static int[] FindMinMaxAverage(int[] arr)
    {
        int min = arr[0];
        int max = arr[0];
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
            if (arr[i] < min)
            {
                min = arr[i];
            }
            sum += arr[i];
        }
        int average = sum / arr.Length;

        int[] result = { min, max, average };
        return result;
    }

    public static void Main()
    {
    }
}