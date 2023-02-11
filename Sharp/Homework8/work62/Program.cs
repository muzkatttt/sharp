/* Задача 62. Напишите программу, которая 
заполнит спирально массив 4 на 4.
Например, на выходе получается такой
массив:
01 02 03 04 
12 13 14 05
11 16 15 06
10 09 08 07 
*/

void SpiralArray(int[,] array)
{
    int temp = 1;
    int row = 0;
    int col = 0;

    while (temp <= array.GetLength(0) * array.GetLength(1))
    {
        array[row, col] = temp;
        temp++;
        if ((row <= col + 1) && (row + col < array.GetLength(1) - 1))
            col++;
        else if ((row < col) && (row + col >= array.GetLength(0) - 1))
            row++;
        else if (row >= col && row + col > array.GetLength(1) - 1)
            col = col - 1;
        else
            row = row - 1;
    }
}

void PrintArray(int[,] inArray)
{
    for (int row = 0; row < inArray.GetLength(0); row++)
    {
        for (int col = 0; col < inArray.GetLength(1); col++)
        {
            if (inArray[row, col] / 10 <= 0)
            {
                Console.Write($"{0}{inArray[row, col]}\t "); // добавила {0} чтобы вывод был как в примере
            }
            else
            {
                {
                    Console.Write($"{inArray[row, col]}\t "); // если двузначное, выводим без 0
                }
            }
        }
        Console.WriteLine(); // переход на новую строку, когда цикл выполнен
    }
}

void Main()
{
    Console.Clear();
    int[,] array = new int[4, 4];
    SpiralArray(array);
    PrintArray(array);
}

Main();