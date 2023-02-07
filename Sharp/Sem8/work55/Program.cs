/*Задача 55: Задайте двумерный массив. 
Напишите программу, которая заменяет строки 
на столбцы. В случае, если это невозможно, 
программа должна вывести сообщение для пользователя
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

int[,] Bardak(int[,] array)
{
    int hight = array.GetLength(0);
    int width = array.GetLength(1);

    int[,] bardakArray = new int[width, hight];
    for (int i = 0; i < hight; i++)
    {
        for (int j = 0; j < width; j++)
        {
            bardakArray[i, j] = array[j, i];
        }
    }
    return bardakArray;

}

void Main()
{
    Console.Clear();
    Console.Write("Введите кол-во строк: ");
    int row = int.Parse(Console.ReadLine()!);
    Console.Write("Введите кол-во столбцов: ");
    int col = int.Parse(Console.ReadLine()!);
    int[,] ourArray = GetArray(row, col, 1, 9);
    PrintArray(ourArray);

    System.Console.WriteLine();
    if (ourArray.GetLength(0) != ourArray.GetLength(1))
    {
        System.Console.WriteLine("Преобразование невозможно");
    }
    else
    {
        PrintArray(Bardak(ourArray));
    }


}

Main();