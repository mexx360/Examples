// **1 группа Методов - ничего не принимают, ничего не возвращают**

void Method1()
{
    Console.WriteLine("Autor...");
}
//  Отключён!!! Method1();


// **2 группа Методов - что-то принимают, ничего не возвращают**

void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Отключён!!! Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
      Console.WriteLine(msg);   
      i++;  
    }
}
// Отключён!!! Method21(msg: "Текст сообщения", count: 4);


// **3 группа Методов - ничего не принимают, что-то возвращают**

int Method3()
{
    return DateTime.Now.Year;
}

int Year = Method3();
// Отключён!!! Console.WriteLine(Year);


// **4 группа Методов - что-то принимают, что-то возвращают**

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(1000, "$");
// Отключён !!! Console.WriteLine(res);