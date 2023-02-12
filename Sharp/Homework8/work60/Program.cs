/* Задача 60. Сформируйте трехмерный массив
из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно 
выводить массив, добавляя индексы каждого элемента.
Массив, размером 2 х 2 х 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

void RandomArray(int[,,] array)
{
    int[] result = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int number;
    for (int i = 0; i < result.GetLength(0); i++)
    {
        int minValue = 10;
        int maxValue = 99;
        result[i] = new Random().Next(minValue, maxValue + 1);
        number = result[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (result[i] == result[j])
                {
                    result[i] = new Random().Next(10, 100);
                    j = 0;
                    number = result[i];
                }
                number = result[i];
            }
        }
    }
    int count = 0;
    for (int y = 0; y < array.GetLength(0); y++)
    {
        for (int x = 0; x < array.GetLength(1); x++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[x, y, z] = result[count];
                count++;
            }
        }
    }
}

void PrintArray(int[,,] array2)
{
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int q = 0; q < array2.GetLength(2); q++)
            {
                Console.Write($"Значение ячейки {array2[i, j, q]} индекс [{i}, {j}, {q}]\t ");
            }
            Console.WriteLine();
        }
        // Console.WriteLine();
    }
}

int SizeInput(string input)
{
    Console.Write(input);
    int size = int.Parse(Console.ReadLine()!);
    return size;
}

void Main()
{
    Console.Clear();
    Console.WriteLine($"Введите размер массива X x Y x Z: ");
    int x = SizeInput("Введите X: ");
    int y = SizeInput("Введите Y: ");
    int z = SizeInput("Введите Z: ");
    Console.WriteLine($" ");
    int[,,] arrayX = new int[2, 2, 2];
    RandomArray(arrayX);
    PrintArray(arrayX);
}
Main();





