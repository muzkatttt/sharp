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
    int find = Find(); // вызов метода из метода
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int k = 0; k < myArray.GetLength(1); k++)
        {
            if (find < myArray[i, k] || find > myArray[i, k])
            {
                Console.WriteLine($"Заданный элемент {find} отсутствует в массиве");
            }
            else if (myArray[i, k] == find)
            {
                Console.WriteLine($"Значение элемента массива {myArray[i, k]}, индекс строки {i}, индекс столбца {k}");
            }
        }
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
    Console.Write("Введите значение: ");
    int find = int.Parse(Console.ReadLine()!);
    return find;
}

Main();