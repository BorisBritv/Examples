
Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if (username.ToLower()=="boria")
{
    Console.WriteLine("ура,это же Boria!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}