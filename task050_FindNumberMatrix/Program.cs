/* 50) Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет
1 4 7 2
5 9 2 3 -> 17 -> такого числа в массиве нет
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

bool FindNumber(int[,] matr, int number)
{
    bool result = false;

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] == number)
            {
                return true;
            }
        }
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
Console.WriteLine("Введите число для поиска: ");
int number = int.Parse(Console.ReadLine());

int[,] matrix = GetRandomIntMatrix(min, max, m, n);
PrintArray(matrix);
Console.WriteLine();

bool result = FindNumber(matrix, number);

if (result == true)
{
    Console.WriteLine($"Число {number} есть в массиве");
}

if (!result)
{
    Console.WriteLine($"Числа {number} нет в массиве");
}
