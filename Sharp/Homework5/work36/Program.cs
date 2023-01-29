/* Задача 36. Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечетных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89 , 6] -> 0
*/

int[] New(int number, int minValue, int maxValue)
{
    int[] output = new int[number];

    for (int i = 0; i < number; i++)
    {
        output[i] = new Random().Next(minValue, maxValue + 1);
    }
    return output;
}

Console.Clear();
int[] odd = New(13, -99, 100); // задаются аргументы
Console.WriteLine(String.Join(" ", odd));

int OddCount(int[] array, int minIndex, int maxIndex)
{
    int sum = 0;
    {
        int i = 0;
        for (int i = 1; i < array; i++);
        {
            if (array[i] % 2 == 1)
            {
                sum++;
            }
            else 
            {
                sum =+ 0;
            }
        }
        return sum;
    }
}

int[] sum = OddCount(array[i], -99, 100);
Console.WriteLine(sum);