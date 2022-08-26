/* 41) Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше нуля ввёл пользователь
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223 -> 3*/

int GetCountPositiveNums(int count)
{
    int result = 0;
    int num = 0;

    for (int i = 0; i < count; i++)
    {
        Console.Write("Напишите число: ");
        num = int.Parse(Console.ReadLine());

        if (num > 0)
        {
            result++;
        }
    }

    return result;
}

Console.Write("Напишите количество чисел: ");
int count = int.Parse(Console.ReadLine());

int result = GetCountPositiveNums(count);

Console.WriteLine($"Среди введенных чисел {result} положительных чисел");
