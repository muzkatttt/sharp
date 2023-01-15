// напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя)
Console.Write("Введите число: ") ;
int number = int.Parse(Console.ReadLine()!) ;

// Решение математически
int num = number * number ;
Console.WriteLine(num) ;
Console.WriteLine($"Квадрат числа {number} равен {num}") ;

// Решение через библиотеку
int num2 = Convert.ToInt32(Math.Pow(number, 2)) ;
Console.WriteLine($"Квадрат числа {number} равен {num2}") ;