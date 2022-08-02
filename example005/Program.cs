Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if (username.ToLower() == "максим") 
{
    Console.WriteLine("Ура это же Максим");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}