/* 63) Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6" */

void PrintN(int count, int N)
{
    if (count > N) return;
    PrintN(count, N - 1);
    Console.Write(N + ", ");
}

string PrintNTwo(int N, int count)
{
    if (N == count) return N.ToString();
    return N + " " + PrintNTwo(N + 1, count);
}

Console.WriteLine("Введите число N: ");
int number = int.Parse(Console.ReadLine());
PrintN(1, number);
Console.WriteLine();
Console.WriteLine(PrintNTwo(1, number));
