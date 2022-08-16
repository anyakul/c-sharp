// Показать строку несколько раз
string ShowStringSomeTimes(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i<count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = ShowStringSomeTimes(10, "asdf ");
Console.WriteLine(res);
