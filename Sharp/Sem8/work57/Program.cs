/*Задача 57. Составить частотный словарь элементов 
двумерного массива. Частотный словарь 
содержит информацию о том, сколько раз 
встречается элемент входных данных.
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