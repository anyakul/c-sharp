/* 54) Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
1 4 7 2    7 4 2 1
5 9 2 3 -> 9 5 3 2
8 4 2 4    8 4 4 2
*/

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

int[] GetRowArray(int[,] matr, int row)
{
    int[] arr = new int[matr.GetLength(1)];
    int k = 0;

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        if (i == row)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                arr[k] = matr[i, j];
                k++;
            }
        }
    }

    return arr;
}

void OrderRowArray(int[] mas)
{
    int temp = 0;

    for (int i = 0; i < mas.Length; i++)
    {
        for (int j = i + 1; j < mas.Length; j++)
        {
            if (mas[i] < mas[j])
            {
                temp = mas[i];
                mas[i] = mas[j];
                mas[j] = temp;
            }
        }
    };
}

void OrderRowMatrix(int[,] matr)
{
    int k;
    int[] array = new int[matr.GetLength(1)];

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        k = 0;
        array = GetRowArray(matr, i);
        OrderRowArray(array);

        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = array[k];
            k++;
        }
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

int[,] matrix = GetMatrix(min, max, m, n);

PrintArray(matrix);
Console.WriteLine();
OrderRowMatrix(matrix);
PrintArray(matrix);
