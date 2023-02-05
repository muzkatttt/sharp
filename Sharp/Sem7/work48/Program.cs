/*48 задача. Задайте двумерный массив размера m на n,
каждый элемент в массиве находится по формуле: Aij = i+j.
Выведите полученный массив на экран.
*/

int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
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

int [,] matr = GetMatrix(5, 8);
PrintArray(matr);

