/* Задача 21. Напишите программу, которая на вход
принимает координаты двух точек и находит
расстояние между ними в 2D пространстве
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21*/

// Найти расстояние между точками
// d = √ (х А – х В) 2 + (у А – у В) 2
Console.Clear(); 
Console.WriteLine($"Введите Х1: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Введите Y1: ");
int y1 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Введите Х2: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Введите Y2: ");
int y2 = int.Parse(Console.ReadLine()!);

double line = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 2);

Console.WriteLine($"Расстояние от точки A({x1},{y1}) до точки B({x2},{y2}) равно {line})");

// второй вариант решения задачи
// double result // - вводим дополнительную переменную
// double result = Math.Sqrt((Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));
// result = Math.Round(result, 3); где 3 - количество цифр после запятой
// Console.WriteLine($"Расстояние между заданными точками {result:F3}"); // округление через {result:F3}, F3 - количество цифр после запятой