/* 45) Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования. */

int[] GetArray(int count, int min, int max)
{
    int[] arr = new int[count];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }

    return arr;
}

int[] CopyArray(int[] mas) 
{
    int[] result = new int[mas.Length];

    for (int i = 0; i < mas.Length; i++)
    {
        result[i] = mas[i];
    }

    return result;
}

Console.Write("Напишите число элементов в массиве: ");
int count = int.Parse(Console.ReadLine());
Console.Write("Напишите минимальное число: ");
int min = int.Parse(Console.ReadLine());
Console.Write("Напишите максимальное число: ");
int max = int.Parse(Console.ReadLine());

int[] arr = GetArray(count, min, max);
int[] res = CopyArray(arr);

Console.WriteLine($"[{String.Join(" ", arr)}]");
Console.WriteLine($"{String.Join(" ", res)}");
