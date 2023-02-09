/* Задача 52. Задайте двумерный массив из
целых чисел. Найдите среднее арифметическое 
элементов в каждом столбце.
Например, задан массив:
1   4   7   2
5   9   2   3
8   4   2   4
Среднее арифметическое каждого столбца:
4,6 5,6 3,6 3 */

int[,] table = new int[3, 4];
GetArray(table);
PrintArray0(table);

double[] num = new double[table.GetLength(1)];

for (int i = 0; i < table.GetLength(1); i++)
{
    double result = 0.0;
    for (int j = 0; j < table.GetLength(0); j++)
    {
        result += table[j, i];
    }
    num[i] = result / table.GetLength(0);
}

PrintArray1(num);

void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray0(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("Среднее арифметическое каждого столбца:");
}

void PrintArray1(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]:F2}\t ");
    }
}
