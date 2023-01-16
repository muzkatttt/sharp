// написать программу, которая принимает на вход 3 числа и выдает максимальное из этих чисел

/* 2, 3, 7 -> 7;
44 5 78 -> 78;
22 3 9 -> 22; */


Console.Write($"Введите число 1:  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите число 2:  ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите число 3:  ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c)
    { 
        Console.WriteLine($"Наибольшее число равно {a}");
    }
else if (b > a && b > c)
    {
        Console.WriteLine($"Наибольшее число равно {b}");
    }
else if (a > b && c > a)
        {
            Console.WriteLine($"Наибольшее число равно {c}");
        }
else if (b > a && c > b)
        {
            Console.WriteLine($"Наибольшее число равно {c}");
        }
else 
        {
            Console.WriteLine($"Наибольшее число не найдено, уточните запрос");
        } 