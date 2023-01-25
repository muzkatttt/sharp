// вывод таблицы уможения с помощью цикла for

for (int i = 2; i <= 10; i++) // for (int i = 2; i < length; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j};");
    }
    Console.WriteLine(); // без этой строки будет выходить без пробела
}
