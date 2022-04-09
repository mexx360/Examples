// **Синтаксис цикла "for" на примере 4 Метода - что-то принимают, что-то возвращают**

string Method4(int count, string text)
{
    
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(100, "*");
Console.WriteLine(res);