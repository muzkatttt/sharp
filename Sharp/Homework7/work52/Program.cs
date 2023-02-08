/* Задача 52. Задайте двумерный массив из
целых чисел. Найдите среднее арифметическое 
элементов в каждом столбце.
Например, задан массив:
1   4   7   2
5   9   2   3
8   4   2   4
Среднее арифметическое каждого столбца:
4,6 5,6 3,6 3 */


double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int k = 0; k < n; k++)
        {
            result[i, k] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int k = 0; k < inArray.GetLength(1); k++)
        {
            Console.Write($"{inArray[i, k]}\t ");
        }
        Console.WriteLine();
    }
}

void SumDouble(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        double sum = 0;
        for (int k = 0; k < arr.GetLength(0); k++)
        {
            sum = arr[k, i] + sum;
        }
        Console.Write($"{sum / arr.GetLength(0):F2}\t");
    }
}

Console.Clear();
Console.Write("Введите кол-во строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);
double[,] array = GetArray(row, col, 0, 10);
PrintArray(array);
SumDouble(array);
