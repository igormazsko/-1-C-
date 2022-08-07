Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "наташа")
{
    Console.WriteLine("Ура! Это же НАТАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
