/* Задача 58. Задайте две матрицы. Напишите программу,
которая будет находить произведение двух матриц.
Например, даны две матрицы
2 4 | 3 4 
3 2 | 3 3
Результирующая матрица будет
18 20
15 18 */

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[2, 2];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

int[,] GetMatrix(int m, int n, int minValue, int maxValue)
{
    int[,] result2 = GetArray(m, n, minValue, maxValue);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result2[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result2;
}

void PrintMatrix(int[,] myMatrix)
{
    for (int i = 0; i < myMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < myMatrix.GetLength(1); j++)
        {
            Console.Write($"{myMatrix[i, j]}\t ");
        }
        Console.WriteLine();
    }
}
void Multiplication(int[,] mult)
{
    int m = 2;
    int n = 2;
    int[,] array = GetArray(m, n, 1, 3);
    int[,] matrix = GetMatrix(m, n, 1, 3);
    int[,] multMatrix = new int[2, 2];
    for (int q = 0; q < multMatrix.GetLength(0); q++)
    {
        for (int w = 0; w < multMatrix.GetLength(1); w++)
        {
            if (q == 0)
            {
                if (q == w)
                {
                    multMatrix[0, 0] = (array[0, 0] * matrix[0, 0]) + (array[0, 1] * matrix[1, 0]);
                }
                else
                {
                    multMatrix[0, 1] = (array[0, 0] * matrix[0, 1]) + (array[0, 1] * matrix[1, 1]);
                }
                Console.Write($" X ");
                Console.Write($"{multMatrix[q, w]}\t");

            }
            else if (q == 1)
            {
                if (q != w)
                {
                    multMatrix[1, 0] = (array[1, 0] * matrix[1, 0]) + (array[1, 1] * matrix[1, 0]);
                }
                else
                {
                    multMatrix[1, 1] = (array[1, 0] * matrix[0, 1]) + (array[1, 1] * matrix[1, 1]);
                }
                Console.Write($" , ");
                Console.Write($"{multMatrix[q, w]}\t");
            }
            // Console.Write($"Результирующая матрица {multMatrix[q, w]}\t");
        }        //q  w          q  w           q  w          q  w           q  w
        // multMatrix[0, 0] = array[0, 0] * matrix[0, 0] + array[0, 1] * matrix[1, 0];
        // Console.Write(multMatrix[0, 0]);
        // multMatrix[0, 1] = array[0, 0] * matrix[0, 1] + array[0, 1] * matrix[1, 1];
        // Console.Write(multMatrix[0, 0]);
        // multMatrix[1, 0] = array[1, 0] * matrix[1, 0] + array[1, 1] * matrix[1, 0];
        // Console.Write(multMatrix[0, 0]);
        // multMatrix[1, 1] = array[1, 0] * matrix[0, 1] + array[1, 1] * matrix[1, 1];
        // Console.Write(multMatrix[0, 0]);
    }
}

Console.Clear();

int[,] array = GetArray(m: 2, n: 2, minValue: 1, maxValue: 3);
PrintArray(array);
Console.WriteLine();
int[,] matrix = GetMatrix(m: 2, n: 2, minValue: 1, maxValue: 3);
PrintMatrix(matrix);
Console.WriteLine();
Multiplication(array);

