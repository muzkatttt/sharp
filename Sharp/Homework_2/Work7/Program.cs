﻿/*задача 15. Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/
Console.Clear();
Console.WriteLine($"Введите число: ");
int a = int.Parse(Console.ReadLine()!);
{
  Console.Write("");
}
if (a < 6 && a > 0)
{
  Console.Write("Нет, не выходной");
}
if (a > 5 && a < 8)
{
    Console.WriteLine($"Да, выходной");
}
if (a < 1 || a > 7)
{
    Console.WriteLine($"Введенное число не обозначает день недели");
}