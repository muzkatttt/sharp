//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.

Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] array = GetArray(12, -9, 9);
Console.WriteLine(String.Join(" ", array));

int positiveSum = 0;
int negativeSum = 0;

foreach (int el in array)
{
    // if (el > 0)
    // {
    //     positiveSum += el;
    // }
    // else 
    // {
    //     negativeSum += el;
    // }

    positiveSum += el > 0 ? el : 0; // тернарная операция
    negativeSum += el < 0 ? el : 0; // тернарная операция
}

Console.WriteLine($"Сумма положительных чисел = {positiveSum}, отрицательных = {negativeSum}");

