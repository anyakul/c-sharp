/* 40) Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон*/

bool GetIfTriangle(int num1, int num2, int num3) 
{
    return num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2;
}

Console.Write("Напишите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Напишите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Напишите третье число: ");
int c = int.Parse(Console.ReadLine());

bool result = GetIfTriangle(a, b, c);

if (result)
{
    Console.WriteLine($"Треугольник со сторонами {a} {b} {c} может существовть");
}

if (!result)
{
    Console.WriteLine($"Треугольник со сторонами {a} {b} {c} существовать не может");
}
