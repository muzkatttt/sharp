/* Задача 52. Задайте двумерный массив из
целых чисел. Найдите среднее арифметическое 
элементов в каждом столбце.
Например, задан массив:
1   4   7   2
5   9   2   3
8   4   2   4
Среднее арифметическое каждого столбца:
4,6 5,6 3,6 3 */


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

double SumDouble(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int k = 0; k < arr.GetLength(1); k++)
        {
            double[,] matrix = new double[i, k];

            arr[i,k] = arr[i,k] + arr[i+1,k];
            Console.Write($"{arr[i,k] / arr.GetLength(1):F2}\t ");
        }
    }
    return arr.GetLength(1);
}

Console.Clear();
Console.Write("Введите кол-во строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);
int [,] array = GetArray(row, col, 0, 10);
PrintArray(array);
double[,] matrix = new double[row,col];
SumDouble(matrix);
