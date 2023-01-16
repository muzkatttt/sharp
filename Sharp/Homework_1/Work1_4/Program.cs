// напишите программу, которая на вход принимает число(N), а на выходе показывает все четные числа от 1 до N
/* 
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
while(count <= number); 
        {
        if (count % 2 == 0);
                {
                Console.WriteLine($"{count} ");
                }
        }
count = count + 2;

/* Console.Write("Введите число:  ");
int number = int.Parse(Console.ReadLine()!);
int count = -number;
while(count <= number); {
        Console.Write($"{count} ");
        count++; // count++ равно count = count + 1
} */
