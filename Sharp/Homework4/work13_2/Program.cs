/* Задача 29. Напишите программу, которая задает массив 
из 8 элементов и выводит их на экран
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

//int[] Array = new int[8] { 1, 2, 5, 7, 19, 6, 1, 33 }; // создаю масссив с 8 новыми элементами
int[] array = ReadArray();
PrintArray(array); // вызов функции
int[] ReadArray()
{
    int[] result = new int[8];
    for (int i = 0; i < 8; i++)
    {
        result[i] = int.Parse(Console.ReadLine()!);
    }
    return result;
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

