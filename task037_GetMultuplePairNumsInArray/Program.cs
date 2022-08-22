/*37) Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

int[] GetArray(int count, int min, int max)
{
    int[] arr = new int[count];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }

    return arr;
}

int[] GetMultiplePairNumsInArray(int[] mas) 
{
    int size = mas.Length / 2;

    if (mas.Length % 2 == 1)
    {
        size++;
    }

    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = mas[i] * mas[mas.Length - 1 - i];
    }

    if (mas.Length % 2 == 1)
    {
        res[size-1] = mas[mas.Length / 2];
    }

    return res;
}

Console.Write("Напишите число элементов в массиве: ");
int count = int.Parse(Console.ReadLine());
Console.Write("Напишите минимальное число: ");
int min = int.Parse(Console.ReadLine());
Console.Write("Напишите максимальное число: ");
int max = int.Parse(Console.ReadLine());

int[] arr = GetArray(count, min, max);
int[] res = GetMultiplePairNumsInArray(arr);

Console.WriteLine($"[{String.Join(", ", arr)}]");
Console.WriteLine($"{String.Join(" ", res)}");
