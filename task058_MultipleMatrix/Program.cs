/*58) Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
2 4 | 3 4 -> 18 20
3 2 | 3 3    15 18 */

int[,] exampleMatrix1 = new int[,]
{
    { 2, 4 },
    { 3, 2 }
};

int[,] exampleMatrix2 = new int[,]
{
    { 3, 4 },
    { 3, 3 }
};

int[,] GetMatrix(int min, int max, int m, int n)
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

int[,] MultipleMatrix(int[,] matr1, int[,] matr2)
{
    int[,] result = new int[matr1.GetLength(0), matr2.GetLength(1)];

    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            result[i, j] = matr1[i, 0] * matr2[0, j] + matr1[i, 1] * matr2[1, j];
        }
    }

    return result;
}

Console.WriteLine("Матрица примера:");
int[,] exampleResult = MultipleMatrix(exampleMatrix1, exampleMatrix2);
PrintArray(exampleResult);

Console.WriteLine();

Console.WriteLine("Введите минимальное число: ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное число: ");
int max = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число элементов в столбце: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число элементов в строке: ");
int n = int.Parse(Console.ReadLine());

int[,] matrix1 = GetMatrix(min, max, m, n);
int[,] matrix2 = GetMatrix(min, max, m, n);

PrintArray(matrix1);
Console.WriteLine();
PrintArray(matrix2);
Console.WriteLine();

int[,] result = MultipleMatrix(matrix1, matrix2);
PrintArray(result);
