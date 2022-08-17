/* 24) Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А. 
7 -> 28. 2, 
4 -> 10, 
8 -> 36
*/

int GetSumNums(int num)
{
    int sum = 0;

    for(int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }

    return sum;
}

Console.Write("Напишите число: ");
int num = int.Parse(Console.ReadLine());
int result = GetSumNums(num);
Console.Write($"Сумма чисел от 1 до {num} равна {result}");
