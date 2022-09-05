/* 59) Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
1 4 7 2
5 9 2 3    9 4 2
8 4 2 4 -> 2 2 6
5 2 6 7    3 4 7 */

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

int[] FindMinNum(int[,] matr)
{
    int min = matr[0, 0];
    int rowMin = 0;
    int colMin = 0;
    int[] res = new int[2];

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] < min)
            {
                min = matr[i, j];
                rowMin = i;
                colMin = j;
            }
        }

        res[0] = rowMin;
        res[1] = colMin;
    }

    return res;
}

int[,] ClearRowColMatrix(int[,] matr, int[] min)
{
    int[,] res = new int[matr.GetLength(0) - 1, matr.GetLength(1) - 1];
    int correctI = 0;
    int correctJ = 0;

    for (int i = 0; i < res.GetLength(0); i++)
    {
        if (i >= min[0]) correctI = i + 1;
        else correctI = i;

        for (int j = 0; j < res.GetLength(1); j++)
        {
            if (j >= min[1]) correctJ = j + 1;
            else correctJ = j;

            res[i, j] = matr[correctI, correctJ];
        }
    }

    return res;
}

Console.WriteLine("Введите минимальное число: ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное число: ");
int max = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число элементов в столбце: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число элементов в строке: ");
int n = int.Parse(Console.ReadLine());

int[,] matrix = GetMatrix(min, max, m, n);

PrintArray(matrix);
int[] minNum = FindMinNum(matrix);
Console.WriteLine($"Минимальное число в матрице - {matrix[minNum[0], minNum[1]]}");
PrintArray(ClearRowColMatrix(matrix, minNum));
