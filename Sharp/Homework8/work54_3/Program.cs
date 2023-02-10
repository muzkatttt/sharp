/* Задача 54. Задайте двумерный массив. Сортирует по столбцам!
Напишите программу, которая упорядочит 
по убыванию элементы каждого столбца двумерного массива.
Например, задан массив
 1 4 7 2
 5 9 2 3
 8 4 2 4 
В итоге получается такой массив
 7 4 2 1 
 9 5 3 2
 8 4 4 2 */

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

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int col = i; col < array.GetLength(1) - j - 1; col++)
            {
                if (array[i, col] > array[i, col + 1])
                {
                    int temp = array[i, col];
                    array[i, col] = array[i, col + 1];
                    array[i, col + 1] = temp;
                }
            }
        }
    }
}

Console.Clear();
Console.Write("Введите кол-во строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(row, col, 1, 9);
PrintArray(array);


Console.WriteLine(string.Join(" ", array));
SortArray(array);
Console.WriteLine(string.Join(" ", array));
PrintArray(array);

