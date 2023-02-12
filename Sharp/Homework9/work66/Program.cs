/*Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


int SumNumbers(int m, int n)
{
    if (n == m) return m; // вычисляем сумму чисел в полуинтервале [m,n)
    else
    {
        return m + SumNumbers(m + 1, n);
    }
}

void Main()
{
    System.Console.WriteLine("Введите число M: ");
    int m = int.Parse(Console.ReadLine()!);
    System.Console.WriteLine("Введите число N: ");
    int n = int.Parse(Console.ReadLine()!);
    Console.WriteLine();
    Console.WriteLine(SumNumbers(m, n));
}
Main();