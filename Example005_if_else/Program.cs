Console.Write("Введите имя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша") //интересная операция ToLower(), как я понял, помогает игнорировать регистр
{
    Console.WriteLine("Да это же сама Маша");
}
else
{
    Console.Write("Привет ");
    Console.WriteLine(username);
}