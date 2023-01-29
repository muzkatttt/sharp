/* Напишите программу, которая на вход принимает число А
и выдает сумму чисел от 1 до А*/


int GetSum(int A)
{
    int sum = 0;
    for (int i = 1; i <= A; i++)
    {
        sum += i;
    }

    return sum;
}

int n = int.Parse(Console.ReadLine()!);
int sum = GetSum(n);
Console.WriteLine($"{sum}");

// можно включить функции ввода и вывода в отдельную функцию main метод void
// void main()
// {
//     Console.Clear();
//     Console.WriteLine("Введите число");
//     int num = int.Parse(Console.ReaLine()!);
//     Console.WriteLine(num);
// }
// main();