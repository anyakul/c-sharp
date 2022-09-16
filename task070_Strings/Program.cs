/* 70) Написать программу, которая из имеющегося массива строкк формирует массив из строк, длина которых меньше либо равна три символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Kazan"] -> []
*/

string[] GetArray(int count)
{
    string[] arr = new string[count];

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("Напишите строку: ");
        arr[i] = Console.ReadLine();
    }

    return arr;
}

string[] CheckLength(string[] arr, int maxLength)
{
    List<string> list = new List<string>();

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= maxLength) {
            list.Add(arr[i]);
        }
    }

    string[] newArr = list.ToArray();

    return newArr;
}

Console.Write("Напишите число элементов в массиве: ");
string text = Console.ReadLine();

if (!int.TryParse(text, out var parsedNumber))
{
    Console.Write("Вы ввели не число");
}

else {
    int num = int.Parse(text);

    string[] arr = GetArray(num);
    Console.WriteLine($"[{String.Join(", ", arr)}]");

    int maxLength = 3;

    string[] newArr = CheckLength(arr, maxLength);
    Console.WriteLine($"[{String.Join(", ", newArr)}]");
}
