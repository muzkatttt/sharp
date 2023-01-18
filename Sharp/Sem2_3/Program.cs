// напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// если число 2 не кратно числу 1, то программа выводит отстаток от деления
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Clear();
Console.WriteLine($"Введите число 1:");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Введите число 2:");
int number2 = int.Parse(Console.ReadLine()!);
int number3 = number1 % number2; 
if(number3 == 0)
{
    Console.WriteLine($"Число {number1} кратно числу {number2}");
}
else
{
    Console.WriteLine($"Число {number1} не кратно числу {number2}, остаток {number3}");
}