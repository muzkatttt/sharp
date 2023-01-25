/* 26. Напишите программу, которая на вход принимает число
и выдает количество цифр в числе
456 -> 3
78 -> 2
89126 -> 5 */

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
int Count(int arg)
{
    int count = 0;
    while(arg > 0)
    {
        arg /= 10;
        count++;
    }
    return count;
}
Console.WriteLine(Count(a));
