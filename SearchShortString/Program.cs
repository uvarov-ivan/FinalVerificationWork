
int InputInt(string msg)
{
    System.Console.Write($"Введите {msg} >");
    return (Convert.ToInt32(Console.ReadLine()));
}

string InputStr(string msg)
{
    System.Console.WriteLine($"Введите {msg} >");
    return (Console.ReadLine());
}


