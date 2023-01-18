/* имеется одномерный массив array из n элементов (с использованием генератора псевдослучайных чисел) 
требуется найти элемент массива, равный find. Решить задачу с использованием метода void*/
void FillArray(int[] collection) // void - метод, при котором значение функции могут не возвращать, 
                                 // метод return, наоборот, возвращает значение функции
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection [index] = new Random().Next(1, 10);
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


int [] array = new int[10]; // команда new int[10] означает - создай новый массив, в котором будет 10 элементов 

FillArray(array); // метод FillArray - заполняет массив данными - принимает ненулевую строковую переменную в качестве аргумента, возвращает массив символов
PrintArray(array); //метод PrintArray будет распечатывать массив