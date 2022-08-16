// Показать строку несколько раз циклом for
string Metod4(int count, string text)
{
string result = String.Empty;
    for (int i = 0; i<count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Metod4(10, "asdf ");
Console.WriteLine(res);
