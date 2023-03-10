// напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя)
Console.Write("Введите число: ") ;
int number = int.Parse(Console.ReadLine()!) ; // все, что мы получили в консоли, конвертируем через Parse из строки в целочисленный тип

// Решение математически
int num = number * number ; // в языке C# недопустимо называть переменные одинкаово, все переменные называются по-разному
Console.WriteLine(num) ;
Console.WriteLine($"Квадрат числа {number} равен {num}") ;
/* int.Parse - если требуется перевести строки в целочисленный тип, convert - любой какой-то тип в другое*/

// Решение через библиотеку 
/* Convert.ToInt32 - используется для того, чтобы конвертировать 
число типа double в тип int, чтобы записать его в тип int. */

int num2 = Convert.ToInt32(Math.Pow(number, 2)) ; // Math - библиотека преобразует результат в тип double, Pow - метод
Console.WriteLine($"Квадрат числа {number} равен {num2}") ; // знак интерполяции $ сообщает программе, что можно работать непосредственно с данными из программы