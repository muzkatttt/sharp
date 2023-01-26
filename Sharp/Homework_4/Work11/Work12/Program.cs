/* Задача 27. Напишите программу, которая принимает на вход число 
и выдает сумму цифр в числе
452 -> 11
82 -> 10
9012 -> 12 */

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число: ");
        int n = int.Parse(Console.ReadLine()!);
        int sum = 0;
        int temp = 0;
        {
            while (n > 0)
            {
                temp = n % 10;
                sum = sum + temp;
                n = n / 10;
            }
            Console.WriteLine($"Сумма цифр числа равна {sum}");
        }
    }
}