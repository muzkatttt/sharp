/*Задача 59. Задайте двумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец, 
на пересечении которых расположен наименьший элемент массива. */

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

int[] minIndexs(int[,] array)
{
    int row = 0;
    int column = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[row, column] > array[i, j])
            {
                row = i;
                column = j;
            }
        }

    }

    return new int[] { row, column };
}

int[,] CutMinLines(int[] indexs, int[,] array)
{
    int hight = array.GetLength(0);
    int widnt = array.GetLength(1);
    int row = 0;
    int column = 0;

    int[,] afterCut = new int[hight - 1, widnt - 1];


    for (int i = 0; i < hight; i++)
    {
        if (indexs[0] == i)
            continue;

        for (int j = 0; j < widnt; j++)
        {
            if (indexs[1] == j)
                continue;
            afterCut[row, column] = array[i, j];
            column++;
        }
        row++;
        column = 0;
    }
    return afterCut;
}

void Main()
{
    Console.Clear();
    Console.Write("Введите кол-во строк: ");
    int row = int.Parse(Console.ReadLine()!);
    Console.Write("Введите кол-во столбцов: ");
    int col = int.Parse(Console.ReadLine()!);
    int[,] ourArray = GetArray(row, col, 1, 99);
    PrintArray(ourArray);
    System.Console.WriteLine();

    PrintArray(CutMinLines(minIndexs(ourArray), ourArray));


    // System.Console.WriteLine();
    // minIndex(ourArray);
    // PrintArray(CutArray(ourArray);


}

Main();

