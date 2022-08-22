/*36) Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] GetArray(int count, int min, int max)
{
    int[] arr = new int[count];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }

    return arr;
}

int CountEvenNumsInArray(int[] mas) 
{
    int count = 0;

    for (int i = 1; i < mas.Length; i+=2)
    {
        count += mas[i];
    }
    return count;
}

Console.Write("Напишите число элементов в массиве: ");
int count = int.Parse(Console.ReadLine());
Console.Write("Напишите минимальное число: ");
int min = int.Parse(Console.ReadLine());
Console.Write("Напишите максимальное число: ");
int max = int.Parse(Console.ReadLine());

int[] arr = GetArray(count, min, max);
int res = CountEvenNumsInArray(arr);

Console.WriteLine($"[{String.Join(", ", arr)}]");
Console.WriteLine($"Сумма элементов стоящих на нечётных позициях равна {res}");
