/* 31) Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/

int[] GetArray(int count, int min, int max)
{
    int[] arr = new int[count];

    for(int i = 0; i < count; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

int count = 12;
int min = -8;
int max = 9;

int[] arr = GetArray(count, min, max);
Console.WriteLine($"[{String.Join(",", arr)}]");

int positiveSum = 0;
int negativeSum = 0;

foreach (int el in arr)
{
    positiveSum += el > 0 ? el : 0;
    negativeSum += el < 0 ? el : 0;
}

Console.Write($"Сумма положительных элементов равна {positiveSum}, а отрицательных - {negativeSum}");
