/* Напишите функцию, которая принимает на вход одно число -
- высоту елочки и рисует ее в консоли звездочками.
продемонстрировать работу функции */

string Fun (char whitespace, int hight);
{
    string result = string.Empty;
}

void FurTree(int h)
{
    int h = 1;
    for (int i = 1; i <= h; i =+ 2)
    {
        if (i < h)
        {
            Console.WriteLine(" { * } ");
            i =+ 2;
        }
        else Console.WriteLine($"Не введена высота елки");
    }
}

string hight = ReadCons("Введите высоту елки: ");
Fun();
FurTree();

int ReadCons(string hight) // считывание с консоли информации пользователя
{
    Console.Write(hight);
    return int.Parse(Console.ReadLine()!);
}

