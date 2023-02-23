// Есть число N, нужно показать числа от -N до N

int GetValueByUser(string text)
{
    int value = 0;
    bool flag = false;
    do
    {
        Console.Write(text);
        string s = Console.ReadLine()!;
        flag = int.TryParse(s, out value) && value > 0;
    } while (!flag);
    return value;
}

void PrintNumbers1(int n)
{
    for (int i = -n; i <= n; i++)
    {
        Console.Write(i + " ");
    }
    System.Console.WriteLine();
}

string PrintNumbers2(int n)
{
    string output = String.Empty;

    for (int i = -n; i <= n; i++)
    {
        output = output + $"{i} ";
    }
    return output;
}

string PrintNumbers3(int n)
{
    string output = "0";
    for (int i = 1; i <= n; i++)
    {
        output = $"{-i} " + output + $" {i}";
    }
    return output;
}

void Main1()
{
    int n = GetValueByUser("введите N ");

    string res = PrintNumbers3(n);
    Console.WriteLine(res);
    File.WriteAllText("data.txt", res);
}

int[] GetRangeSum1(int[] array, int m)
{
    int n = array.Length;
    int[] t = new int[n - m + 1];

    int index = 0;

    for (int i = 0; i <= n - m; i++)
    {
        for (int j = i; j < i + m; j++)
        {
            t[index] += array[j];
        }
        index++;
    }
    return t;
}

int[] GetRangeSum2(int[] array, int m)
{
    int n = array.Length;
    int[] t = new int[n - m + 1];

    int index = 0;
    for (int i = 0; i < m; i++) t[index] += array[i];

    for (int i = 1; i <= n - m; i++)
    {
        index++;
        t[index] = t[index - 1] - array[i - 1] + array[i + m - 1];
    }
    return t;
}


int[] CreateArray(int size) => new int[size];

string Print(int[] array) => $"[{String.Join(", ", array)}]";

void Fill(ref int[] array) => array = array.Select(e => Random.Shared.Next(10)).ToArray();

int[] numbers = CreateArray(5);
Fill(ref numbers);
Console.WriteLine(Print(numbers));

int count = 2;
int[] sumGroupNumbers = GetRangeSum2(numbers, count);
Console.WriteLine(Print(sumGroupNumbers));

Console.WriteLine("+");
