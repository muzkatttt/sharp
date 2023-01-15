Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "катя")
{
    Console.WriteLine("Ура, это же Катя!");
}
else 
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
