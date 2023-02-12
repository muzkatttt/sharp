/* Задача 56. Задайте прямоугольный двумерный
массив. Напишите программу, которая будет 
находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3 
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке
и выдает номер строки с наименьшей суммой элементов:
1 строка */

int[,] GetArray(int row, int col, int minValue, int maxValue)
{
    int[,] result = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
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
    Console.WriteLine();
}


void MinIndexes(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (sum < minRow)
        {
            minRow = sum;
            minSumRow = i;
        }
        sum = 0;
    }
    Console.Write($"Номер строки с наименьшей суммой элементов:\t {minSumRow} строка");
}
Console.Clear();
Console.Write("Введите кол-во строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(row, col, 4, 13);
PrintArray(array);
MinIndexes(array);
