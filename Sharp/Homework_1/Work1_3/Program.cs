﻿// напишите программу, которая на вход принимает число и выдает, является ли оно четным (делится ли оно на два без остатка)
/* 
4 -> да
-3 -> нет
7 -> нет */

Console.Write($"Введите число:  ");
double a = Convert.ToInt32(Console.ReadLine());

if (a % 2 ==0)
{
    Console.WriteLine($"{a} является четным числом");
}
else
{
    Console.WriteLine($"{a} является нечетным числом");
}