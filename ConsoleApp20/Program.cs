using ConsoleApp20;

Console.WriteLine("я программа");
UserService service = new UserService(); // выделил память

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
    Console.WriteLine("Введите логин");
    string login = Console.ReadLine();
    Console.WriteLine("Введите пароль");
    string password = Console.ReadLine();

    foreach (User us in service.Users)
    {
        if(us.Login == login && us.Password == password)
        {
            Console.WriteLine("привет " + us.Name);
            return;
        }
    }
    Console.WriteLine("пользователь не  найден");

}

void AddUser()
{
    Console.WriteLine("Введите имя");
    string name = Console.ReadLine();
    Console.WriteLine("Введите логин");
    string login = Console.ReadLine();
    Console.WriteLine("Введите пароль");
    string password = Console.ReadLine();

    User user = new User();
    user.Name = name;
    user.Password = password;
    user.Login = login;

    service.Users.Add(user);
    Console.WriteLine("пользователь  добавлен");
}