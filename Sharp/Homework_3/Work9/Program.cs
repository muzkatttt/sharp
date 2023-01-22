/* Задача 21. Напишите программу, которая принимает
на вход координаты двух точек и находит расстояние между ними
в 3D пространстве.
A (3,6,8); B (2,1,7) -> 15,84; // расстояние 15,84 равно если точка B имеет координаты (2,1,-7)!
A (7,-5,0); B (1,-1,9) -> 11,53;*/

// Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)+ Math.Pow((z2 - z1), 2));

Console.Clear();
Console.WriteLine($"Введите Х1: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Введите Y1: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Введите Z1: ");
int z1 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Введите Х2: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Введите Y2: ");
int y2 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Введите Z2: ");
int z2 = int.Parse(Console.ReadLine()!);
double x3 = Math.Pow(x2 - x1, 2);
double y3 = Math.Pow(y2 - y1, 2);
double z3 = Math.Pow(z2 - z1, 2);
double line = Math.Sqrt(x3 + y3 + z3);
Console.WriteLine($"Расстояние от точки A({x1},{y1},{z1}) до точки B({x2},{y2},{z2}) равно {line:F2}");