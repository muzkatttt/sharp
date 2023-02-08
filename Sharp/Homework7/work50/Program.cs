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

void FindElement(int[,] myArray, int row, int col)
{
    int findElement = Find(); // вызов метода из метода
    int count = 0;
    int rows = myArray.GetLength(0);
    int columns = myArray.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int k = 0; k < columns; k++)
        {
            if (myArray[i, k] == findElement)
            {
                Console.WriteLine($"Значение {myArray[i, k]}, индекс {i},{k}");
                count++;
            }
        }
    }
    if (count == 0)
    {
        Console.WriteLine($"Элемент не найден");
    }
}


void Main()
{
    Console.Clear();
    Console.Write("Введите кол-во строк: ");
    int row = int.Parse(Console.ReadLine()!);
    Console.Write("Введите кол-во столбцов: ");
    int col = int.Parse(Console.ReadLine()!);
    int[,] array = GetArray(row, col, 1, 10);
    PrintArray(array);
    FindElement(array, row, col);
}

int Find()
{
    Console.Write("Какое число ищем в массиве? Введите: ");
    int find = int.Parse(Console.ReadLine()!);
    return find;
}

Main();