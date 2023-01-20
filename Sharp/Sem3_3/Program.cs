/* Задача No22. Работа в группах
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
от 1 до N.
5 -> 1, 4, 9, 16, 25. 
2 -> 1,4 */

Console.Clear();
Console.WriteLine($"Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int count = 1;
while(count <= n)
{
if (count < n) Console.Write($"{count * count}, ");
else Console.Write($"{count * count}");
count++;
}
