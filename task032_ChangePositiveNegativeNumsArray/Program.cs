/* 32) Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]*/

int[] GetArray(int count, int min, int max)
{
    int[] arr = new int[count];

    for (int i = 0; i < count; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

int[] ChangePositiveNegativeNumsArray(int[] mas) 
{
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] *= -1;
    }

    return mas;
}

Console.Write("Напишите число элементов в массиве: ");
int count = int.Parse(Console.ReadLine());
Console.Write("Напишите минимальное число: ");
int min = int.Parse(Console.ReadLine());
Console.Write("Напишите максимальное число: ");
int max = int.Parse(Console.ReadLine());

int[] arr = GetArray(count, min, max);
Console.WriteLine($"[{String.Join(", ", arr)}]");

int[] changeArray = ChangePositiveNegativeNumsArray(arr);
Console.WriteLine($"[{String.Join(", ", changeArray)}]");
