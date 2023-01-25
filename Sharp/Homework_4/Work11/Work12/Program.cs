/* Задача 27. Напишите программу, которая принимает на вход число 
и выдает сумму цифр в числе
452 -> 11
82 -> 10
9012 -> 12 */

int Sum(int n)
    {   
        for(int i = 0; i < n; i++)
            {
                int temp = result;
                result = n % 10;
                temp = result;
            }
            i++;
        return result;
    }

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);

void PrintSum => Console.Write(Sum);
Console.WriteLine(Sum(result));

