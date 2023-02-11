/* Задача 60. Сформируйте трехмерный массив
из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно 
выводить массив, добавляя индексы каждого элемента.
Массив, размером 2 х 2 х 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

void FillArray(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(10, 100);
    }
}

void OutputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

void ShuffleArray(int[] array)
{
    Random random = new Random();
    for (int i = array.Length - 1; i >= 0; i--)
    {
        int randomItem = random.Next(i);
        int shuffledElement = array[randomItem];
        array[randomItem] = array[i];
        array[i] = shuffledElement;
    }
}

void Main(string[] args)
{
    int[] array = new int[8];
    FillArray(array);
    Console.WriteLine("Исходный массив");
    OutputArray(array);
    ShuffleArray(array);
    Console.WriteLine("\n Перемешанный массив");
    OutputArray(array);
}

Main(args);