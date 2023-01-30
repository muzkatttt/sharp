/* Задача 36. Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечетных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89 , 6] -> 0
*/

int[] New(int numbers, int minValue, int maxValue)
{
    int[] output = new int[numbers];

    for (int i = 0; i < numbers; i++)
    {
        output[i] = new Random().Next(minValue, maxValue + 1);
    }
    return output;
}

void main()
{
    Console.Clear();
    int[] array = New(8, -99, 100); // задаются аргументы
    Console.WriteLine(String.Join(" ", array));

    int sumOdd = 0;
    for (int index = 1; index < array.Length; index += 2)
    {
        sumOdd += array[index];
    }
    Console.WriteLine($"Cумма чисел с нечетными индексами = {sumOdd}");
}

main();