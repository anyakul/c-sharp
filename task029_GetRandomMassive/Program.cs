/* 29) Напишите программу, которая задаёт массив из N элементов, заполненных случайными числами из [a, b) и выводит их на экран
5, 0, 20 -> [1, 2, 5, 7, 19]
3, 1, 35 -> [6, 1, 33]
*/

void GetRandomArray(int count, int min, int max)
{
    int[] arr = new int[count];

    for(int i=0; i<count; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
    Console.WriteLine($"[{String.Join(",", arr)}]");
}

Console.Write("Напишите число элементов в массиве: ");
int count = int.Parse(Console.ReadLine());
Console.Write("Напишите минимальное число: ");
int min = int.Parse(Console.ReadLine());
Console.Write("Напишите максимальное число: ");
int max = int.Parse(Console.ReadLine());
GetRandomArray(count, min, max);
