Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "Maxim")
{
    Console.WriteLine("Ура, это же Maxim");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}