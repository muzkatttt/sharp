Console.Write($"Введите число ");
int number = int.Parse(Console.ReadLine()!);
int count = -number;
while(count <= number) 
{
        Console.Write($"{count} ");
        count++; // count++ равно count = count + 1
}

/* напишите программу, которая на вход принимает число(N), 
а на выходе показывает все целые числа от -N до N */
