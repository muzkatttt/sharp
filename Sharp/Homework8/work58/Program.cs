/* Задача 58. Задайте две матрицы. Напишите программу,
которая будет находить произведение двух матриц.
Например, даны две матрицы
2 4 | 3 4 
3 2 | 3 3
Результирующая матрица будет
18 20
15 18 */

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[2, 2];
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

int[,] GetMatrix(int m, int n, int minValue, int maxValue)
{
    int[,] result2 = GetArray(m, n, minValue, maxValue);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result2[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result2;
}

void PrintMatrix(int[,] myMatrix)
{
    for (int i = 0; i < myMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < myMatrix.GetLength(1); j++)
        {
            Console.Write($"{myMatrix[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

int[,] MultiplicationMatrix(int[,] array, int[,] matrix)
{
    int[,] multy = new int[array.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int q = 0; q < matrix.GetLength(0); q++)
            {
                multy[i, j] += array[i, q] * matrix[q, j];
            }
        }
    }
    return multy;
}

void PrintMulty(int[,] myArray)
{
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            Console.Write("{0} ", myArray[i, j]);
        }
        Console.WriteLine();
    }
}

void Main()
{
    Console.Clear();
    int[,] array = GetArray(m: 2, n: 2, minValue: 1, maxValue: 2);
    PrintArray(array);
    Console.WriteLine();
    int[,] matrix = GetMatrix(m: 2, n: 2, minValue: 1, maxValue: 3);
    PrintMatrix(matrix);
    Console.WriteLine();
    int[,] mult = MultiplicationMatrix(array, matrix);
    PrintMulty(mult);
}

Main();

