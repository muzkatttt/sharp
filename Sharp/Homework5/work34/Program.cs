/* Задача 34. Задайте массив, заполненный случайными 
положительными трёхзначными числами. Напишите программу, 
которая покажет количество четных чисел в массиве
[345, 897, 568, 234] -> 2
*/

int[] ThreeDigitNumber(int nums, int min, int max) // заполняю массив элементами
{
    int[] result = new int[nums];

    for (int i = 0; i < nums; i++)
    {
        result[i] = new Random().Next(min, max + 1); // min входит, max + 1 тоже входит 
    }
    return result;
}

Console.Clear();
int[] even = ThreeDigitNumber(9, 100, 1000); // 9 - количество чисел в массиве, 100 - минимальное трехзн.число
//Console.Write("Сгенерированный массив: ");
Console.WriteLine(String.Join(" ", even)); // без этой команды программа не показывает сгенерированный массив

int evenNums = 0;
foreach (int elem in even)
{
    if (elem % 2 == 0)
    {
        evenNums += 1;
    }
    else
    {
        evenNums += 0;
    }
}
Console.WriteLine($"Количество четных чисел в массиве = {evenNums}");
