/* Задача 29. Напишите программу, которая задает массив 
из 8 элементов и выводит их на экран
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

void FillArray(int[] nums)
{
    int Length = nums.Length;
    int index = 0;

    while (index < Length)
    {
        int nums;
        
        Console.WriteLine({nums});
        index++;
    }
}

void PrintArray(int [] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int [] array = new int[8];

FillArray(array);
PrintArray(array);

int ReadConsol(string msg) // считывание с консоли информации пользователя
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}


// /* имеется одномерный массив array из n элементов (с использованием генератора псевдослучайных чисел) 
// требуется найти элемент массива, равный find, который будет возвращать позицию, т.е. индекс элемента.
// Решить задачу с использованием метода, отличного от void т.е. методом IndexOf*/
// void FillArray(int[] collection) // void - метод, при котором значение функции могут не возвращать, 
//                                  // метод return, наоборот, возвращает значение функции
// {
//     int Length = collection.Length;
//     int index = 0;
//     while (index < Length)
//     {
//         collection [index] = new Random().Next(1, 10);
//         index++;
//     }
// }
// void PrintArray(int [] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.WriteLine(col[position]);
//         position++;
//     }
// }

// int IndexOf(int[] collection, int find)
// {
//     int count = collection.Length;
//     int index = 0;
//     int position = 0;
//     while (index < count)
//     {
//         if(collection[index] == find)
//         {
//             position = index;
//             break; // оператор break вводится, если достаточно найти индекс первого элемента, равного в примере =4
//         }
//         index++;
//     }
//     return position;
// }

// int [] array = new int[10]; // команда new int[10] означает - создай новый массив, в котором будет 10 элементов 

// FillArray(array); // метод FillArray - заполняет массив данными - принимает ненулевую строковую переменную в качестве аргумента, возвращает массив символов
// array[4] = 4; // принудительное заполнение значения элемента в ячейке с индексом 4
// array[6] = 4; // принудительное заполнение значения элемента в ячейке с индексом 6
// PrintArray(array); //метод PrintArray будет распечатывать массив
// Console.WriteLine(); // эту строку кода вводим для того, чтобы отделить массив от значения искомого индекса элемента

// int pos = IndexOf(array, 4);
// Console.WriteLine(pos);