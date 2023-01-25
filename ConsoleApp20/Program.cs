Console.WriteLine("я программа");

while (true)
{
    Console.WriteLine("Список команд:");
    Console.WriteLine("Регистрация -  \"add user\"");
    Console.WriteLine("Вход в  систему -  \"in\"");
    Console.WriteLine("Выход -  \"exit\"");
    Console.WriteLine("очистить консоль -  \"clear\"");

    string com = Console.ReadLine();

    switch (com)
    {
        case "add user": AddUser(); break; ;
        case "in": AutUser(); break;
        case "clear": Console.Clear(); break;
        case "exit": return; ;
        default:
            Console.WriteLine("команда не  ясна - попробуйте  еще раз");
            break;
    }
}

void AutUser()
{
    throw new NotImplementedException();
}

void AddUser()
{
    throw new NotImplementedException();
}