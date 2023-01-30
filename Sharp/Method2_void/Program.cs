﻿//Метод 2 - void - метод, который ничего не возвращает, но в то же время может принимать какие-то аргументы

//void Method2(string msg)
//{
//    Console.WriteLine(msg);
//}
//Method2(msg: "Второй метод не возвращает, но может принимать агрументы");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Второй метод принимает аргумент msg, но не возвращает его", count: 3);
// Method21(count: 3, msg: "Второй метод принимает аргумент msg, но не возвращает его");
// Method21("Второй метод принимает аргумент msg, но не возвращает его", 3); так тоже можно
// когда переменные именованы, можно указывать их не по порядку