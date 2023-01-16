// на вход принимает число  N, а на выходе показывает все четные числа от 1 до N
/* 5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.Write($"Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 0;
while (i <= number)
    {
        if (i % 2 == 0);
        {
            Console.WriteLine($"{i} ");
        }
    i = i + 1;
    }