/* Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным 
элементом массива
*/

int[] MyArray(int size, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1); // + new Random().Next(0.01, 10.0);
    }
}

int[] array = 
Console.Clear();
//double[] array = New(20, 0, 1); // задаются аргументы
Console.WriteLine(String.Join(" ", array));
int num = double.Parse(Console.ReadLine()!);

// Random rand = new Random();
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = 5 - rand.Next(11) + rand.NextDouble();
// }

// Console.ReadLine();