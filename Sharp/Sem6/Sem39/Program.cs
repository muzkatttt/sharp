/* Задача 39.Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем)
*/

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

void ReversArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        int temp = inArray[i]; 
        inArray[i] = inArray[inArray.Length - 1 - i];
        inArray[inArray.Length - 1 - i] = temp;
    }
}

int[] ReversArray2(int[] inArray)
{
    int length = inArray.Length;
    int[] result = new int[length];

    for (int i = 0; i < length; i++)
    {
        result[i] = inArray[length - 1 - i];
    }
    return result;
}

int[] array = GetArray(10, 0, 10);
Console.WriteLine(String.Join(" ", array));

// ReversArray(array);
// Console.WriteLine(String.Join(" ", array));
int[] reversed = ReversArray2(array);
Console.WriteLine(String.Join(" ", reversed));
Console.WriteLine(String.Join(" ", array));

