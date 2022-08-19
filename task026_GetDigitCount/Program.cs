/* 26) Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе. 
456 -> 3, 
78 -> 2, 
89126 -> 5
*/

int GetDigitCount(int num)
{
    int count = 0;

    while(num > 0)
    {
        count++;
        num = num / 10;
    }

    return count;
}

Console.Write("Напишите число: ");
int num = int.Parse(Console.ReadLine());
int result = GetDigitCount(num);
Console.Write($"В числе {num} - {result} чисел");
