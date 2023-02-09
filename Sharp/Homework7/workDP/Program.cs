/* Задача 50. Напишите программу, которая на вход 
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же 
указание, что такого элемента нет.
Например, задан массив
1   4   7   2
5   9   2   3
8   4   2   4

17 -> такого числа в массиве нет
*/

Console.Write("Введите индекс строки: ");
int lin = int.Parse(Console.ReadLine()!);
Console.Write("Введите индекс столбца: ");
int row = int.Parse(Console.ReadLine()!);
int[,] table = new int[3, 4];
GetArray(table);
PrintArray(table);

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

Console.WriteLine();

if (lin < table.GetLength(0) && row < table.GetLength(1))
{
    Console.WriteLine(table[lin, row]);
}
else Console.WriteLine($"Числа с индексом строки {lin} индексом столбца {row} в массиве нет");