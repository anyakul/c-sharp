/* 60) Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

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

void MixArray(int[] array)
{
    int temp;
    int j;

    for (int i = array.Length - 1; i >= 1; i--)
    {
        j = new Random().Next(i + 1);
        temp = array[j];
        array[j] = array[i];
        array[i] = temp;
    }
}

int[,,] GetMultiMatrix(int[] array, int m, int n, int t)
{
    int k = 0;
    int[,,] matr = new int[m, n, t];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int l = 0; l < t; l++)
            {
                matr[i, j, l] = array[k];
                k++;
            }
        }
    }

    return matr;
}

void PrintArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int l = 0; l < matr.GetLength(2); l++)
            {
                Console.Write($"{matr[i, j, l]} ({i}, {j}, {l}) ");
            }

            Console.WriteLine();
        }
    }
}

Console.WriteLine();

int min = 10;
int max = 100;
Console.WriteLine("Введите число элементов в столбце (от 1 до 4): ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число элементов в строке: (от 1 до 4)");
int n = int.Parse(Console.ReadLine());
int k = m;

int[] array = NumsFromAToB(min, max);
MixArray(array);

int[,,] matrix = GetMultiMatrix(array, m, n, k);
PrintArray(matrix);
