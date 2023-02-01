/* Задача 40: Напишите программу, которая принимает 
на вход три числа и проверяет, может ли существовать 
треугольник сo сторонами такой длины
*/

bool IsItTriangle(int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
}

Console.Clear();
Console.WriteLine("введите первую сторону: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите вторую сторону: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите третью сторону: ");
int c = int.Parse(Console.ReadLine()!);

bool answer = IsItTriangle(a, b, c);
if (answer)
{
    Console.WriteLine("Существует");
}
else
{
    Console.WriteLine("Не существует");

}
