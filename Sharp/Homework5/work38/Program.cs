/* Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным 
элементом массива
*/

double Difference(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    double diff = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
        else if (arr[i] > max) max = arr[i];
    }
    diff = max - min;
    Console.WriteLine($"max = {max}; min = {min}");
    Console.WriteLine($"Разница = {diff}");
    return diff;
}

double[] RandomArray(double minValue, double maxValue)
{
    Random nums = new Random();
    double[] numbers = new double[3];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = nums.NextDouble() + new Random().Next(1, 10);
    }
    return numbers;
}

double[] myArray = RandomArray(0, 10);
Console.WriteLine(String.Join(" ", myArray));
Difference(myArray);









