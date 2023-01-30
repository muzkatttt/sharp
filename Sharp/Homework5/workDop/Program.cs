/* Разобраться с алгоритмом сортировки методом пузырька.
Реализовать невозрастающую сортировку.
[3, 0, 2, 4 , -1] -> [4, 3, 2, 0, -1]
[1, 2, 2, 3 , 2] -> [3, 2, 2, 2, 1]
*/


int[] Rand(int numbers, int min, int max)
{
    int[] arr = new int[numbers];

    for (int i = 0; i < numbers; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}

Console.Clear();
int[] array = Rand(4, 1, 5); // задаются аргументы
Console.WriteLine(String.Join(" ", array));


void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length -1; i++)
    {
        int max = i;
        
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] > array[max]) max = j;
        }
    
        int temporary = array[i];
        array[i] = array[max];
        array[max] = temporary;
    }
    return max;
}

PrintArray(array);
SelectionSort(max);

Rand(arr);