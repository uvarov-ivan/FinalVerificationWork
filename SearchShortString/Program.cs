
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

string[] GenArray(int len)
{
    string[] newArray = new string[len];
    for (int i = 0; i < len; i++)
    {
        newArray[i] = InputStr($"{i+1}-й элемент");
    }
    return newArray;
}


