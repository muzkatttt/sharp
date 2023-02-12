/*Задача 65. Задайте значения M и N. 
Напишите программу, которая выведет все 
натуральные числа в промежутке от M до N.
 M = 1; N = 5 -> "1, 2, 3, 4, 5" 
 M = 4; N = 8 -> "4, 6, 7, 8"
*/

string PrintNumbers(int m, int n)
{
    if (n == m) return n.ToString();
    else
    {
        return PrintNumbers(m, n - 1) + " " + n.ToString();
    }
}

Console.WriteLine(PrintNumbers(4, 8));
