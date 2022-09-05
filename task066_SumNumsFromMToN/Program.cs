/* 66) Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int SumNums(int m, int n)
{
    int sum = 0;
    if (m > n) return 0;
    sum += m;
    return sum + SumNums(m + 1, n);
}

Console.WriteLine("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine());
int sum = SumNums(m, n);
Console.WriteLine($"Сумма чисел от {m} до {n} равна {sum}");
