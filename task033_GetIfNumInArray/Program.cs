/*33) Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да*/

int[] GetArray(int count, int min, int max)
{
    int[] arr = new int[count];

    for (int i = 0; i < count; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

bool GetNumInArray(int[] mas, int num) 
{
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] == num) {
            return true;
        }
    }

    return false;
}

Console.Write("Напишите число элементов в массиве: ");
int count = int.Parse(Console.ReadLine());
Console.Write("Напишите минимальное число: ");
int min = int.Parse(Console.ReadLine());
Console.Write("Напишите максимальное число: ");
int max = int.Parse(Console.ReadLine());
Console.Write("Напишите искомое число: ");
int num = int.Parse(Console.ReadLine());

int[] arr = GetArray(count, min, max);
Console.WriteLine($"[{String.Join(",", arr)}]");

bool res = GetNumInArray(arr, num);

if (res == true)
{
    Console.WriteLine($"В массиве есть число {num}");
}

if (res == false)
{
    Console.WriteLine($"В массиве нет числа {num}");
}

