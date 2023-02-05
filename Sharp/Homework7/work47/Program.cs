/* Задача 47. Задайте двумерный массив
размером m x n, заполненный случайными 
вещественными числами
m = 3, n = 4
0,5     7       -2      -0,2
1       -3,3    8       -9,9
8       7,8     -7,1       9      
*/

double[,] RandomDouble(int m, int n, double minValue, double maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble()*(maxValue - minValue) + minValue;
        }
    }
    return result;
}

void PrintArray(double[,] myArray)
{
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            Console.Write($"{myArray[i,j]:F2}\t "); // ура! разобралась с округлением чисел
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите кол-во строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);

double[,] arr = RandomDouble(row, col, 0, 100);
PrintArray(arr);