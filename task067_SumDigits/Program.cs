/* 67) Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9 */

int SumNumber(int num)
{
    return num <= 0 ? 0 : num % 10 + SumNumber(num / 10);
}

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр: " + SumNumber(num));
