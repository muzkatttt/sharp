/* Задача 43. Напишите программу, которая найдёт точку
пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
y1 = k1x + b1; y2 = k2x + b2;
x = (b2 - b1)/(k1 - k2); y = k1x + b1;
*/

double ReadConsole(string msg)
{
    Console.Write(msg);
    return double.Parse(Console.ReadLine()!);
}

Console.Clear();
double b1 = ReadConsole("Введите значение b1: ");
double k1 = ReadConsole("Введите значение k1: ");
double b2 = ReadConsole("Введите значение b2: ");
double k2 = ReadConsole("Введите значение k2: ");

void CalculationXY() //double abscissa, double ordinate
{
    double x = 0;
    double y = 0;
    
    if ((k1 == k2) && (b1 != b2))
    {
        Console.WriteLine("Прямые параллельны");
    }
    else if ((k1 == k2) && (b1 == b2))
    {
        Console.WriteLine("Прямые совпадают");
    }
    else
    {
        x = (b2 - b1) / (k1 - k2);
        y = (k1 * x) + b1;
        Console.WriteLine($"Координаты точки пересечения прямых x = {x}, y = {y}");
    }
}

CalculationXY();

