    /*
    Дан текст . В тексте нужно все пробелы заменить черточками,
    маленькие буквы к заменить большими К.
    А большие С на маленькие с.
    */

        
string text = "Федя и Кузьма молчали. Кузьма незаметно подмигнул Феде, они вышли на улицу."

+ "– Я вот чего пришел: Любавины с покоса приехали?"

+ "– Приехали."

+"– Возьми Яшу и подожди меня здесь. Я домой заскочу на минуту (Шукш.)."

+"Оба способа оформления прямой речи могут сочетаться, если в речь одного лица включается еще прямая речь другого лица:"

+"– Я так сказал?";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for( int i = 0; i < length; i++)
    {
        if(text[i] == oldValue)
        result = result + $"{newValue}";
        else
        result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();


