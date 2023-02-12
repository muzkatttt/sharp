/* Задача 67: Напишите программу, которая 
будет принимать на вход число и возвращать 
сумму его цифр.
453 -> 12,
45 -> 9 */

int SumDigits(int num)
{
    if (num == 0) return 0;
    else return num % 10 + SumDigits(num / 10);
}
Console.WriteLine(SumDigits(243));