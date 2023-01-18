/* напишите программу, которая принимает на вход два числа
 и проверяет, является ли одно число квадратом второго*/

Console.Clear();
Console.WriteLine($"Введите число1: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Введите число2: ");
int x = int.Parse(Console.ReadLine()!);

if(n * n == x || x * x == n)
{
    Console.WriteLine($"Да");
}
else
{
     Console.WriteLine($"Нет");
}