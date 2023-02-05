/* Задача 51. Задайте двумерный массив. 
Найдите сумму элементов, находящихся 
на главной диагонали (с индексами (0,0); (1;1) и т.д.
*/

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
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

int SummDiag(int[,] arrayForSumm)
{
    int summ = 0; //  в начале пишем условие, которое мы проверяем далее знак ? (объявляем тернарный оператор) после ? ставим true через  : если условие не будет выполнено (false)
    int x = arrayForSumm.GetLength(0) > arrayForSumm.GetLength(1) ? arrayForSumm.GetLength(1) : arrayForSumm.GetLength(0);
    for (int i = 0; i < x; i++)
    {
        summ += arrayForSumm[i,i];
    }

    return summ;

}

// int SummDiag(int[,] arrayForSumm) // можно записать код так
// {
// int summ = 0;
// for (int i = 0, j = 0; i < arrayForSumm.GetLength(0) && j < arrayForSumm.GetLength(1); i++, j++)
//      {
//          summ += arrayForSumm[i,j]   
//      }
//      return summ;
// }


Console.Clear();
Console.Write("Введите кол-во строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(row, col, 0, 10);
PrintArray(array);
Console.WriteLine(SummDiag(array));
