/* 56) Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

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

int[] CountRows(int[,] matr)
{
    int k = 0;
    int[] count = new int[matr.GetLength(0)];

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        count[k] = 0;

        for (int j = 0; j < matr.GetLength(1); j++)
        {
            count[k] += matr[i, j];
        }

        k++;
    }

    return count;
}

int CompareRows(int[] array)
{
    int min = array[0];
    int minI = 0;

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            minI = i;
        }
    }

    return minI;
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

int[] array = CountRows(matrix);
Console.WriteLine($"[{String.Join(", ", array)}]");

int minRow = CompareRows(array) + 1;
Console.WriteLine($"Строка с минимальной суммой элементов - {minRow}");
