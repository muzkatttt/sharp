/* Задача. Напишите программу, которая 
заполнит спирально массив 4 на 4 единицами.
Например, на выходе получается такой
массив:
1 1 1 1 
0 0 0 1
1 0 0 1
1 1 1 1 */

void Main()
{
    int[,] array = new int[4, 4];
    int size = 4;
    int i = 0;
    int j = 0;

    for (j = 0, i = 0; j < size; j++)
        array[i, j] = 1;

    for (i = 0, j = size - 1; i < size; i++)
        array[i, j] = 1;

    for (j = size - 1, i = size - 1; j >= 0; j--)
        array[i, j] = 1;

    int count = 3;
    int c = 0;

    i = size - 1;
    j = 0;

    for (int x = size - 3; x > 0; x -= 2)
    {
        if (size % 2 == 0 & x == 1)
            c = 1;
        else
            c = 0;

        while (c < 2)
        {
            switch (count)
            {
                case 1: //Down
                    for (int t = 0; t < x; t++)
                    {
                        i++;
                        array[i, j] = size + 1;
                    }
                    count++;
                    break;
                case 2: //Left
                    for (int t = 0; t < x; t++)
                    {
                        j--;
                        array[i, j] = size + 1;
                    }
                    count++;
                    break;
                case 3: //Up
                    for (int t = 0; t < x; t++)
                    {
                        i--;
                        array[i, j] = 1;
                    }
                    count++;
                    break;
                case 4: //Right
                    for (int t = 0; t < x; t++)
                    {
                        j++;
                        array[i, j] = 1;
                    }
                    count = 1;
                    break;
            }
            c++;
        }
    }

    for (int ii = 0; ii < size; ii++)
    {
        for (int jj = 0; jj < size; jj++)
            Console.Write($"{array[ii, jj]} \t");
        Console.WriteLine();
    }
}

Main();