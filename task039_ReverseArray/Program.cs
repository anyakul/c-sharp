/*39) Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]*/

int[] GetArray(int count, int min, int max)
{
    int[] arr = new int[count];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }

    return arr;
}

int[] ReverseArray(int[] mas) 
{
    int[] result = new int[mas.Length];
    for (int i = 0; i < mas.Length; i++)
    {
        result[i] = mas[mas.Length - 1 - i];
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
int[] res = ReverseArray(arr);

Console.WriteLine($"[{String.Join(" ", arr)}]");
Console.WriteLine($"{String.Join(" ", res)}");
