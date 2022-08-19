/* 28) Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

int GetMultipleNumbers(int num)
{
    int result = 1;

    for(int i = 2; i <= num; i++)
    {
        result = result * i;
    }

    return result;
}

Console.Write("Напишите число:");
int num = Convert.ToInt32(Console.ReadLine());
int result = GetMultipleNumbers(num);
Console.Write($"Произведение чисел от 1 до N равно {result}");
