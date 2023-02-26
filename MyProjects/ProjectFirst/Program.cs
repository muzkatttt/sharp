/* Задача: Написать программу, которая 
из имеющегося массива строк формирует 
массив из строк, длина которых меньше 
либо равна 3 символам. Первоначальный 
массив можно ввести с клавиатуры либо 
задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться 
коллекциями, лучше обойтись исключительно массивами.
[“hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */

void Main()
{
    Console.Write($"Введите количество строковых элементов: ");
    int elem = int.Parse(Console.ReadLine()!);
    string[] array = new string[elem];
    int j = 0;

    for (int i = 0; i < elem; i++)
    {
        Console.WriteLine($"Введите {i + 1}-й элемент: ");
        string element = Convert.ToString(Console.ReadLine()!);

        if (element.Length < 4)
        {
            array[j] = element;
            j++;
        }
    }
    PrintArray(array);
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

Console.WriteLine();
Main();
