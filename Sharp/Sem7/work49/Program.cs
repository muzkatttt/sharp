/* Задача 49. Задайте двумерный массив. 
Найдите элементы, у которых оба индекса
чётные, и замените эти элементы на их квадраты.
*/

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return result;
}

void SquareArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i += 2)
    {
        for(int j = 0; j < array.GetLength(1);  j += 2)
        {
            array[i, j] *= array[i, j]; // array[i, j] = array[i, j] * array[i, j];
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t "); // знак "\t" позволяет делать отсупы между элементами массива при выводе на консоль
        }
        Console.WriteLine();
    }
}

int[,] matr = GetArray(5, 5, -9, 9);
PrintArray(matr);
SquareArray(matr);
Console.WriteLine();
PrintArray(matr);