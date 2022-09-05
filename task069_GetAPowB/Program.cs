/* 69) Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */

int PowRec(int a, int b)
{
    if (b == 0) return 1; 
    else if (b % 2 == 0) return PowRec(a * a, b / 2);
    else return a * PowRec(a, b - 1);
}

Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine($"A в степени B равна: " + PowRec(a, b));
