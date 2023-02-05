/*Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/

void main()
{
    Console.Write("введите  число: ");
    int inputNumber = int.Parse(Console.ReadLine()!);
    string ReversInt = Return01(inputNumber);
    Console.WriteLine(ReversInt);
}

string Return01(int number)
{
    string number01 = string.Empty;
    while (number > 0) // выполняем код до тех пор, пока не закончится остаток от нашего числа
    {
        number01 = (number % 2).ToString() + number01; // каждый остаток приплюсовываем с левой стороны к пустой строке 
        number /= 2;
    }
    return number01;
}

main();
