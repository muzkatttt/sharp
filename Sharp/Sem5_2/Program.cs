/*Задача 32: Напишите программу замены элементов массива: 
положительные элементы замените на соответствующие отрицательные, 
и наоборот. [-4, -8, 8, 2] -> [4, 8, -8, -2] 
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

void Convert(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
}

int[] array = GetArray(12, -9, 9);
Console.Write("Сгенерированный массив: ");
Console.WriteLine(String.Join(" ", array));
Convert(array);
Console.WriteLine(String.Join(" ", array));