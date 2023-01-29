// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] Multiply(int[] Arraymultiply)
{
    int NeedSize = 0;
    if (Arraymultiply.Length % 2 != 0)
    {
        NeedSize = Arraymultiply.Length / 2 + 1;
    }
    else
    {
        NeedSize = Arraymultiply.Length / 2;
    }

    int[] MultyArray = new int[NeedSize];

    for (int j = 0; j < NeedSize; j++)
    {
        if (Arraymultiply[j] == Arraymultiply[Arraymultiply.Length - 1 - j])
        {
            MultyArray[j] = Arraymultiply[j];
        }
        else
        {
            MultyArray[j] = Arraymultiply[j] * Arraymultiply[Arraymultiply.Length - 1 - j];
        }
    }
    return MultyArray;
}

int[] ourArray = GetArray(7, 0, 10);
System.Console.WriteLine(String.Join(" ", ourArray));
int[] rezultArray = Multiply(ourArray);
System.Console.WriteLine(String.Join(" ", rezultArray));

