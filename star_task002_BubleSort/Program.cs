/* 2*: Разобраться с алгоритмом сортировки методом пузырька. Реализовать невозрастающую сторировку.
[3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
[1,2,2,3,2] -> [3, 2, 2, 2, 1]
*/

int[] GetArray(int count, int min, int max)
{
    int[] arr = new int[count];

    for (int i = 0; i < count; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

int[] BubbleSort(int[] mas) 
{
    int temp = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        for (int j = i + 1; j < mas.Length; j++)
        {
            if (mas[i] < mas[j])
            {
                temp = mas[i];
                mas[i] = mas[j];
                mas[j] = temp;
            }
        }
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
Console.WriteLine($"[{String.Join(",", arr)}]");
int[] sortArr = BubbleSort(arr);
Console.WriteLine($"[{String.Join(",", sortArr)}]");
