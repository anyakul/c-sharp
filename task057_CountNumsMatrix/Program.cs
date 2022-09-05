/* 57) Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раза
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза */

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

int[] GetRowArray(int[,] matr)
{
    int k = 0;

    int[] nums = new int[matr.GetLength(0) * matr.GetLength(1)];

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            nums[k] = matr[i, j];
            k++;
        }
    }

    return nums;
}

void SortArray(int[] array)
{
    int temp = 0;

    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
}

void CountNums(int[] array)
{
    int count = 1;

    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] == array[i + 1])
        {
            count++;
        }

        else
        {
            Console.WriteLine($"{array[i]} встречается {count} раза");
            count = 1;
        }
    }

    Console.WriteLine($"{array[array.Length - 1]} встречается {count} раза");
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
int[] array = GetRowArray(matrix);
Console.WriteLine($"[{String.Join(", ", array)}]");
SortArray(array);
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine();
CountNums(array);
