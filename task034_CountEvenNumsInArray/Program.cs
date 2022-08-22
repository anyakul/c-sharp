/*34) Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

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

    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] % 2 == 1) {
            count++;
        }
    }
    return count;
}

Console.Write("Напишите число элементов в массиве: ");
int count = int.Parse(Console.ReadLine());
int min = 100;
int max = 999;

int[] arr = GetArray(count, min, max);
int res = CountEvenNumsInArray(arr);

Console.WriteLine($"[{String.Join(", ", arr)}]");
Console.WriteLine($"В массиве {res} чётных элементов");
