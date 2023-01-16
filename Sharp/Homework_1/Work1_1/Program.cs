// задача 2. Напишите программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньше

/* a = 5 ; b = 7 -> max = 7;
a = 2 ; b = 10 -> max = 10
a = -9 ; b = -3 */


Console.WriteLine($"Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
  Console.WriteLine($"Наибольшее число равно {a}");
}

else
{
  Console.WriteLine($"Наибольшее число равно {b}");
}
