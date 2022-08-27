/* 47) Задайте двумерный массив размером mхn, заполненный случайными вещественными числами
m = 3, n = 4
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 1 9
*/

double[,] GetRandomDoubleMatrix(int min, int max, int m, int n)
{
    double[,] matr = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matr[i,j] = new Random().NextDouble() * (min - max) + max;
            matr[i, j] = Math.Round(matr[i,j], 2);
        }
    }

    return matr;
}

void PrintArray(double[,] matr)
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

double[,] matrix = GetRandomDoubleMatrix(min, max, m, n);

PrintArray(matrix);
