/* 61) Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника */

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] != 0)
            {
                Console.Write($"{matr[i, j]} ");
            }
        }

        Console.WriteLine();
    }
}

int[,] GetPascaleTriangle(int n)
{
    int k = 0;
    int[,] matr = new int[n, n];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j <= k; j++)
        {
            if (j == 0 || j == k)
            {
                matr[i, j] = 1;
            }

            else
            {
                matr[i, j] = matr[i - 1, j - 1] + matr[i - 1, j];
            }
        }

        k++;
    }

    return matr;
}

Console.Write("Введите число строчек треугольника паскаля: ");
int n = int.Parse(Console.ReadLine());
int[,] matrix = GetPascaleTriangle(n);
PrintArray(matrix);
