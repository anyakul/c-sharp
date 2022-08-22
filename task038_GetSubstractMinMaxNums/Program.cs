/* 38) Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

double[] GetArray(int count, int min, int max)
{
    double[] arr = new double[count];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().NextDouble() * (min - max) + max;
    }

    return arr;
}

double GetSubstructMinMaxNums(double[] mas) 
{
    double min = mas[0];
    double max = mas[0];
    double res = 0;

    for (int i = 1; i < mas.Length; i++)
    {
        if (mas[i] > max) {
            max = mas[i];
        }

        if (mas[i] < min) {
            min = mas[i];
        }
    }

    res = max - min;
    return res;
}

Console.Write("Напишите число элементов в массиве: ");
int count = int.Parse(Console.ReadLine());
Console.Write("Напишите минимальное число: ");
int min = int.Parse(Console.ReadLine());
Console.Write("Напишите максимальное число: ");
int max = int.Parse(Console.ReadLine());

double[] arr = GetArray(count, min, max);
double res = GetSubstructMinMaxNums(arr);
double result = Math.Round(res, 2);

Console.WriteLine($"[{String.Join(", ", arr)}]");
Console.WriteLine($"Разница между максимальным и минимальным числом массива составляет {result}");
