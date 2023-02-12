/*Задача 63: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

string PrintNumbers(int n)
{
    if (n == 1) return "1";
    else
    {
        return PrintNumbers(n - 1) + " " + n.ToString();
        // return PrintNumbers(n - 1) + $" {n}"; можно так, метод тоже работает
    }
}
Console.WriteLine(PrintNumbers(8));