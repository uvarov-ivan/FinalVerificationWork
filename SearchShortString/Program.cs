
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

(string[], int) SearchShotString(string[] array, int maxLengthStr)
{
    int countElement = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxLengthStr)
        {
            (array[i], array[countElement]) = (array[countElement], array[i]);
            countElement++;
        }
    }
    return(array, countElement);
}

string[] ResaltArray (string[]array, int countElement)
{
    string[] resaltArray = new string [countElement];
    for (int i = 0; i < countElement; i++)
    {
        resaltArray[i] = array[i];
    }
    return resaltArray;
}

void PrintArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.WriteLine();
}

int arrayLength = InputInt("длину массива");
int maxLengthString = InputInt("максимальную длину строки которую будем искать");
string[]myArray = GenArray(arrayLength);
PrintArray(myArray);
(string[]newArray, int amountElements) = SearchShotString(myArray,maxLengthString);
PrintArray(ResaltArray(newArray,amountElements));
