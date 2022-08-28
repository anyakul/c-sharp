/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

1 4 7 2
5 9 2 3
8 4 2 4

m = 1, n =7 -> такого числа в массиве не
*/

int[,] GetRandomIntMatrix(int min, int max, int m, int n)
{
    int[,] matr = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matr[i, j] = new Random().Next(min, max);
        }
    }

    return matr;
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }

        Console.WriteLine();
    }
}

int FindNumber(int[,] matr, int m, int n)
{
    return matr[m, n];
}

Console.WriteLine("Введите минимальное число: ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное число: ");
int max = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число элементов в столбце: ");
int cols = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число элементов в строке: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер строки: ");
int n = int.Parse(Console.ReadLine());

int[,] matrix = GetRandomIntMatrix(min, max, cols, rows);
PrintArray(matrix);
Console.WriteLine();

if (m < matrix.GetLength(0) && n < matrix.GetLength(1))
{
    int result = FindNumber(matrix, m, n);
    Console.WriteLine($"C координатами ({m} {n}) находится число {result})");
}

Console.WriteLine($"Такого числа в массиве нет");
