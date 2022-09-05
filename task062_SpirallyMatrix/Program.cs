/* 62) Заполните спирально массив 4 на 4.
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int[] NumsFromAToB(int a, int b)
{
    int[] arr = new int[b - a];
    int k = a;
    int i = 0;

    while (k != b)
    {
        arr[i] = k;
        k++;
        i++;
    }

    return arr;
}

int[,] SpirallyMatrix(int[] arr, int m)
{
    var result = new int[m, m];
    int k = 0;
    int padding = 0;
    int i = padding;
    int j = padding;

    while (k < m * m)
    {
        for (j = padding; j < m - 1 - padding; j++)
        {
            result[i, j] = arr[k];
            k++;
        }

        for (i = padding; i < m - 1 - padding; i++)
        {
            result[i, j] = arr[k];
            k++;
        }

        for (j = m - 1 - padding; j > padding; j--)
        {
            result[i, j] = arr[k];
            k++;
        }

        for (i = m - 1 - padding; i > padding; i--)
        {
            result[i, j] = arr[k];
            k++;
        }

        padding++;
        i++;
    }

    return result;
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

Console.WriteLine("Введите число элементов в столбце и строке (чётное): ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное число: ");
int min = int.Parse(Console.ReadLine());
int max = min + m * m;

int[] array = NumsFromAToB(min, max);
Console.WriteLine();
int[,] matrix = SpirallyMatrix(array, m);
PrintArray(matrix);
