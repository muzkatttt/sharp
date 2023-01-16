// напишите программу, которая будет выдавать название дня недели по заданному номеру

Console.Write("Введите число ") ;
int x  = int.Parse(Console.ReadLine());
{
  Console.Write("");
}
if (x==1)
{
  Console.Write("Понедельник");
}


if (x==2)
{
  Console.Write("Вторник");
}
if (x==3)
{
  Console.Write("Среда");
}
if (x==4)
{
  Console.Write("Четверг");
}
if (x==5)
{
  Console.Write("Пятница");
}

else if (x < 1 || x > 7)
{
  Console.Write($"Этого дня недели не существует");
}
