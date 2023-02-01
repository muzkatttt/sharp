/*
Напишите программу, которая выводит массив из 8 элементов,
заполненный нуляи и единицами в случайном порядке
[1, 0, 1, 1, 0, 1, 0, 0]
*/

void PrintArray(int[] array)
{
    string ourArray = " ";
    for (int i = 0; i < array.Length; i++)
    {
        ourArray += array[i];
        if (i != array.Length - 1) ourArray += ", ";
    }
    Console.WriteLine(ourArray);
}

// можно так записать код
// void main()
// {
//     int[] intArray = new int[8];
//     for (int i = 0; i < intArray.Length; i++)
//     {
//         int randInt = new Random().Next(0, 2); // ставим 2 - т.к. значение не входит в интервал!
//         intArray[i] = randInt;
//     }
//PrintArray(intArray);
// }

// main();

int[] getArray()
{
    int[] intArray = new int[8];

    for (int i = 0; i < intArray.Length; i++)
    {
        int randInd = new Random().Next(0, 2);
        intArray[i] = randInd;
    }
    return intArray;
}

int[] array = getArray();
Console.WriteLine(String.Join(", ", array));
