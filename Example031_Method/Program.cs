// 1Тип метода : ничего не принимает , ничего не возвращает!
/*
void Method1()
{
    Console.WriteLine("Barbareush Irina");
}

Method1();
*/

// 2Тип метода : принимает аргумент , но ничего не возвращает!
/*
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("Text"); можно так оформлять , можно как в строке ниже.
Method2(msg : "Text");
*/
/*
void Method21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

// Method21("Text", 4); //  указывает сколько раз повториться первый аргумент.
//Method21(msg : "Text", count : 2);
Method21(count: 5, msg: "Text");
*/

// 3Тип метода : ничего не принимает, чтото возвращает.

/*
int Method3()
{
 return DateTime.Now.Year;   
}

int year = Method3();
Console.WriteLine(year);
*/

// 4Тип метода: что-то принимает, что-то возвращает.

string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;
    while(i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}
string res = Method4(10, "asdf ");
Console.WriteLine(res);
