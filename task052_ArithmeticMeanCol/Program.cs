/* 52) Задайте двумерный массив из целых чисел. Найдите среднее арифметическое в каждом столбце
1 4 7 2
5 9 2 3 -> 4,6; 5,6; 36; 3;
8 4 2 4
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

double[] ArithmeticMeanCol(int[,] matr)
{
    int rows = matr.GetLength(0);
    int cols = matr.GetLength(1);

    double[] result = new double[cols];
    int row = 0;
    int col = 0;

    for (int i = 0; i < cols; i++)
    {
        result[i] = 0;

        while (row < rows)
        {
            result[i] = (result[i] + matr[row, col]);
            row++;
        }

        result[i] = Math.Round((result[i] / rows), 2);
        col++;
        row = 0;

    }

    return result;
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
double[] result = ArithmeticMeanCol(matrix);

PrintArray(matrix);
Console.WriteLine("Среднее арифметическое столбцов: ");
Console.WriteLine($"{String.Join("; ", result)}");
