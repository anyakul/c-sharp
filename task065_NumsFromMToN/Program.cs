/* 65) Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8" */

void PrintN(int M, int N)
{
    if (M > N) return;
    PrintN(M, N - 1);
    Console.Write(N + ", ");
}

string PrintNTwo(int M, int N)
{
    if (M == N) return M.ToString();
    return M + " " + PrintNTwo(M + 1, N);
}

Console.WriteLine("Введите число M: ");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());
PrintN(M, N);
Console.WriteLine();
Console.WriteLine(PrintNTwo(M, N));
