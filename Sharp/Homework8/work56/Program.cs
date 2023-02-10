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

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    // n = m + 1;
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


void MinIndexes(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        int sumMin = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = array[i, j] + sum;
            if (sum <= sumMin)
            {
                sum = sumMin;
                temp = i;
            }
            Console.WriteLine($"Строка масива с наименьшей суммой {array[temp, j]}");
        }
    }

}


Console.Clear();
Console.Write("Введите кол-во строк: ");
int row = int.Parse(Console.ReadLine()!);
int col = row + 2;
int[,] array = GetArray(row, col, 0, 10);
PrintArray(array);
MinIndexes(array);
