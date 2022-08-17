/* 27) Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
452 -> 11, 
82 -> 10, 
9012 -> 12
*/

int GetSumDigits(int num)
{
    int result = 0;

    while(num != 0)
    {
        int digit = num % 10;
        result = result + digit;
        num = num / 10;
    }

    return result;
}

Console.Write("Напишите число: ");
int num = int.Parse(Console.ReadLine());
int result = GetSumDigits(num);
Console.Write($"Сумма цифр в числе {num} равна {result}");
