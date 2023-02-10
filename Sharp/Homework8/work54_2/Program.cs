/* Задача 54. Задайте двумерный массив.
Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
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

int[,] SortArray(int[,] array)
{
    int temp = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int row = i; row < array.GetLength(0); row++)
            {
                for (int col = (row == i) ? j : 0; col < array.GetLength(1); col++)
                {
                    if (array[i, j] < array[row, col])
                    {
                        temp = array[row, col];
                        array[row, col] = array[i, j];
                        array[i, j] = temp;
                    }
                }
            }
        }
    }
    return array;
}


Console.Clear();
Console.Write("Введите кол-во строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(row, col, 1, 9);
PrintArray(array);

int[,] myArray = SortArray(array);
Console.WriteLine(string.Join(" ", array));
SortArray(myArray);
Console.WriteLine(string.Join(" ", array));
PrintArray(array);

