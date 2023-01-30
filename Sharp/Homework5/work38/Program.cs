/* Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным 
элементом массива
*/

double[] array = new double[double numbers, double min, double max];

Random random = new Random();
for (int i = 0; i < 10; i++)
{
        array[i] = random.NextDouble() * 100; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
        Console.Write("{0,11:F2}", array[i]);
}

