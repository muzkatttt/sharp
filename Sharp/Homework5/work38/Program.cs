/* Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным 
элементом массива
*/

double[] array = new double[] { };
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new NextDouble(0, 1); // + new Random().Next(0.01, 10.0);
    }
}

Console.Clear();
//double[] array = New(20, 0, 1); // задаются аргументы
Console.WriteLine(String.Join(" ", array));

Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = 5 - rand.Next(11) + rand.NextDouble();
}

Console.ReadLine();