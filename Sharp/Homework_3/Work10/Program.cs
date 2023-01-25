/* Задача 23. Напишите программу, которая 
на вход принимает число N и выдает таблицу 
кубов чисел от 1 до N.
3 -> 1, 4, 9
5 -> 1, 8, 27, 64, 125 */

Console.Write($"Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int count = 1;
while (count <= n)
{
    Console.Write($"{Math.Pow(count, 3)}"); // Math.Pow - переводит в тип данных double
    if (count < n) Console.Write(", ");
    count++;
}

// второй вариант решения задачи
// while (count <= n)
// {
//     if (count < n)
//     Console.Write($"{count * count * count}, ");
//     else
//     Console.Write($"{count * count * count}");
// count++;
// }