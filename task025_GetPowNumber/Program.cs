/* 25) Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
3, 5 -> 243
2, 4 -> 16
*/

int GetPowNumber(int a, int b)
{
    int result = 1;

    for(int i = 1; i <= b; i++)
    {
        result = result * a;
    }

    return result;
}

Console.WriteLine("Напишите 2 числа:");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int result = GetPowNumber(a, b);
Console.Write($"Число {a} в степени {b} равняется {result}");
