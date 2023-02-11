/* Задача 60. Сформируйте трехмерный массив
из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно 
выводить массив, добавляя индексы каждого элемента.
Массив, размером 2 х 2 х 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */


int[] RandomArray(int nums, int minValue, int maxValue) // заполняю массив элементами
{
    int[] result = new int[nums];

    for (int i = 0; i < nums; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}\t ");
    }
    Console.WriteLine();
}


int[] Shuffle(int[] array)
{
    int random = new Random().Next();
    for (int i = array.Length; i > 1; i--)
    {
        int j = new Random().Next(i);
        int temp = array[j];
        array[j] = array[i - 1];
        array[i - 1] = temp;
    }
    return array;
}

void Main()
{
    Console.Clear();
    int[] array = RandomArray(nums: 8, minValue: 10, maxValue: 100);

    PrintArray(array);
    Console.WriteLine();
    Shuffle(array);
    PrintArray(array);

}
Main();
