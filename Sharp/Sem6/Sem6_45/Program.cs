/* Задача 45: Напишите программу, которая 
будет создавать копию заданного массива 
с помощью поэлементного копирования */

int[] GetRandomArray(int lenght, int min, int max)
{
    int[] array = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int[] CopyArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}

Console.Clear();
int[] array = GetRandomArray(10, 0 , 10);
int[] newArray = CopyArray(array);
Console.WriteLine(string.Join(" ", array));
Console.WriteLine(string.Join(" ", newArray));

