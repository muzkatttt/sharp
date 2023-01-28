/* Задача 25. Напишите цикл, который принимает на вход
два числа (А и В) и возводит число А в натуральную степень В.
Реализовать функцию возведения в степень самостоятельно. нельзя использовать функцию Math.
3, 5 -> 243
2, 4 -> 16 
*/

int Extent(int a, int b) // возведение в степень
{
    int result = 1;
    for (int count = 1; count <= b; count++)
    {
        result = result * a;
    }
    return result;
}

int ReadConsol(string msg) // считывание с консоли информации пользователя
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

Console.Clear();
int a = ReadConsol("Введите число А: ");
int b = ReadConsol("Введите натуральное число B: ");
int pow = Extent(a, b); // вызов функции Extent

Console.Write(pow);
