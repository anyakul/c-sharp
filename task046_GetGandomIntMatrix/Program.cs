/*46) Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1
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

Console.WriteLine("Введите минимальное число: ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное число: ");
int max = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число элементов в столбце: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число элементов в строке: ");
int n = int.Parse(Console.ReadLine());

int[,] matrix = GetRandomIntMatrix(min, max, m, n);

PrintArray(matrix);
