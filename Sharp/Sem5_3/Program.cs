// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] GetRandomArray (int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size ; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int FindInRange (int[] array, int lowBorder, int highBorder)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= lowBorder && i <= highBorder)
        {
            count++;
        }
    }
    return count;
}

int[] array = GetRandomArray(123, 0, 150);
Console.Write("Сгенерированный массив: ");
Console.WriteLine(String.Join(" ", array));
int count = FindInRange(array, 10, 99);
Console.WriteLine(count);

