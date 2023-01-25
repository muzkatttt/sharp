// метод 4 - наиболее распространенный метод, который принимает
// и возвращает аргументы

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; // String.Empty - пустая строка
    
    while (i < count)
    {
        result = result + text;
        i++;
    
    }
    return result;
}

string res = Method4(30, "Kate ");
Console.WriteLine(res);
