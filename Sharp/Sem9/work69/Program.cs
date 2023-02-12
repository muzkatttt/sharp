/*Задача 69: Напишите программу, которая на вход 
принимает два числа A и B, и возводит число А 
в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 
A = 2; B = 3 -> 8
*/

void Main()
{
    System.Console.WriteLine("Введите число A: ");
    int numberA = int.Parse(Console.ReadLine()!); //     int numberA = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите число B: ");
    int numberB = int.Parse(Console.ReadLine()!);
    System.Console.WriteLine(Pow(numberA, numberB));
}

int Pow(int a, int b)
{
    if (b == 0) return 1;
    else
    {
        return a * Pow(a, b - 1);
    }
}

Main();
