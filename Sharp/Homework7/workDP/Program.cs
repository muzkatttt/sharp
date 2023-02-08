Console.Write("Введите индекс строки: ");
int lin = int.Parse(Console.ReadLine()!);
Console.Write("Введите индекс столбца: ");
int row = int.Parse(Console.ReadLine()!);

int[,] table = new int[5, 6];
int[,] matrix = new int[lin, row];

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
            int[,] elem =
            if (inArray[i, j] == elem[i, j])
        {
            Console.WriteLine($"{inArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] array = GetArray(4, 5, 1, 10);
PrintArray(array);

if (row < matrix.GetLength(0) && lin < matrix.GetLength(1))
{
    Console.WriteLine(matrix[row, lin]);
}
else
{
    Console.WriteLine($"{lin}{row} -> такого числа в массиве нет");
}
