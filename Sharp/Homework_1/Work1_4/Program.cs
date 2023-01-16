// напишите программу, которая на вход принимает число(N), а на выходе показывает все четные числа от 1 до N
/* 
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Write($"Введите число:  ");
int N = Convert.ToInt32(Console.ReadLine());
int num = 0;
count = 0;

if (N % 2 == 0)
{ 
    num = 0 + 2;
    count = count +2;
    {
        Console.WriteLine($"{N} ");
        Console.WriteLine ($"{num}");
    }
}

else if (N < 0)
{
    Console.WriteLine($"{N} не является положительным числом");
}