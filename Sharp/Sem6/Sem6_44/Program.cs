// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

void WriteFibonachy(int number)
{
    int firtsFib = 0;
    int secondFib = 1;
    for (int i = 1; i <= number; i++)
    {
        System.Console.WriteLine(firtsFib);
        int temp = secondFib;
        secondFib = firtsFib + secondFib;
        firtsFib = temp;
    }
}

void Main()
{
    System.Console.Write("Введите число: ");
    int inputNumber = int.Parse(Console.ReadLine()!);
    WriteFibonachy(inputNumber);
}

Main();

