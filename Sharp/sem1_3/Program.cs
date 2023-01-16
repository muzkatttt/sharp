// Напишите программу, которая на входе запрашивает 3-х значное число, а на выходе показывает его последнюю цифру

Console.WriteLine("Введите 3х значное число: ");
int num3 = int.Parse(Console.ReadLine()!);
int numX = num3 % 10;
Console.Write(numX);