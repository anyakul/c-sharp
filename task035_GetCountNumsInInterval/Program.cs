/*35) Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
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

int GetCountNumsInInterval(int[] mas, int minInterval, int maxInterval) 
{
    int count = 0;

    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] >= minInterval && mas[i] <= maxInterval) {
            count += 1;
        }
    }

    return count;
}

int count = 123;
Console.Write("Напишите минимальное число: ");
int min = int.Parse(Console.ReadLine());
Console.Write("Напишите максимальное число: ");
int max = int.Parse(Console.ReadLine());
int minInterval = 10;
int maxInterval = 99;

int[] arr = GetArray(count, min, max);
int res = GetCountNumsInInterval(arr, minInterval, maxInterval);

Console.WriteLine($"[{String.Join(",", arr)}]");
Console.WriteLine($"В массиве {res} элементов из интервала от {minInterval} до {maxInterval}");
