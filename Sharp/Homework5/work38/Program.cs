/* Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным 
элементом массива
*/

Random rand = new Random();
double[] numbers = new double[10];
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rand.NextDouble() + new Random().Next(1, 100);
}
Console.Clear();
Console.WriteLine(String.Join(" ", numbers));

