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
            result[i, j] = new Random().Next(minValue, maxValue+1);
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

double[,] ArithmeticMeanCol(int m, int n, double min, double max)
{
    double[,] matrix = new double[m,n];
    double sum = 0;
    double arithmetic = 0;
    for (int i = 0; i < m; i++)
    {
        for (int k = 0; k < n; k++)
        {
            sum = matrix[i+1,k] + sum;
            arithmetic = sum / n;
            Console.WriteLine($"{arithmetic}");
        }
    }
    return matrix;
    
}

Console.Clear();
Console.Write("Введите кол-во строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(row, col, 0, 10);
PrintArray(array);
ArithmeticMeanCol(row, col, 0, 10);
