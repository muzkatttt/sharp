/* напишите программу, которая по заданному номеру 
четверти показывает диапазон возможных координат 
точек в этой четверти (x и y) - решение через if и else*/
Console.Clear();
Console.Write("Введите номер четверти: ");
int quarter = int.Parse(Console.ReadLine()!);

if (quarter == 1 || quarter == 4) // положительный X
{
    if (quarter == 1) Console.WriteLine($"В {quarter} четверти X и Y равны от 0 до бесконечности");
    else Console.WriteLine($"В {quarter} четверти X равен от 0 до бесконечности, Y равен от минус бесконечности до 0");
}
else // отрицательный Y
{
    if (quarter == 2) Console.WriteLine($"В {quarter} четверти X равен от минус бесконечности до 0, Y от 0 до бесконечности");
    else Console.WriteLine($"В {quarter} четверти X и Y равны от минус бесконечности до 0");
}