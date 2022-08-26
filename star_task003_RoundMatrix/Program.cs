/* 3*) Напишите приграмму, которая реализует обход двумерного массива, начиная с крайнего нижнего левого угла против часовой стрелки
1 2 3
4 5 6 -> 7 8 9 6 3 2 1 4 5
7 8 9
*/

int[,] FillArray(int min, int max, int cols, int rows)
{
    int[,] matr = new int[cols, rows];

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(min, max);
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }

    return matr;
}

int[] RoundMatrix(int[,] matrix, int row, int col, int rows, int cols)
{
    int size = cols * rows;
    int N = rows - 1;
    int[] arr = new int[size];

    for (int i = 0; i < arr.Length; i++) {
        arr[i] = matrix[col, row];

        if (row < N && col == N)
        {
            row++;
        }

        else if (row == N && col > 0)
        {
            col--;
        }

        else if (row <= N && col == 0 && row != 0)
        {
            row--;
        }

        else if (row == 0 && col >= 0)
        {
            col++;
        }

        if (i == arr.Length / 2 + 2)
        {
            N--;
        }
    }

    return arr;
}

Console.WriteLine("Введите минимальное число: ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное число: ");
int max = int.Parse(Console.ReadLine());

int startRow = 0;
int startCol = 2;
int cols = 3;
int rows = 3;


int[,] matrix = new int[cols, rows];
matrix = FillArray(min, max, cols, rows);

int[] result = RoundMatrix(matrix, startRow, startCol, rows, cols);

Console.WriteLine($"[{String.Join(", ", result)}]");
