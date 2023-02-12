/*Задача 68: Напишите программу вычисления 
функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int AkkermanFunction(int m, int n)
{
    int a = 0;
    if (m == 0) return a = n + 1;
    else if (m > 0 && n > 0) return a = AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    else if (m > 0 && n == 0) return a = AkkermanFunction(m - 1, 1);
    return a;
}

void Main()
{
    System.Console.WriteLine("Введите неотрицательное число m: ");
    int m = int.Parse(Console.ReadLine()!);
    System.Console.WriteLine("Введите неотрицательное число n: ");
    int n = int.Parse(Console.ReadLine()!);
    Console.WriteLine();
    Console.WriteLine(AkkermanFunction(m, n));
}
Main();
