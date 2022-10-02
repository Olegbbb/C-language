Console.WriteLine("Введите имя пользователя");
string? username = Console.ReadLine();

if(username?.ToLower() == "олег")
{
    Console.WriteLine("Ебать ты красавчик");
}
else
{
    Console.Write("Съебал отсюда, ");
    Console.WriteLine(username);
}
