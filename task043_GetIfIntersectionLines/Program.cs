/* 43) Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2, k2 задаются пользователем
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -o,5)
 */

void GetIfIntersectionLines(double b1, double k1, double b2, double k2)
{
    double[] arr = new Double[2];
    double x = (b2 - b1)/(k1 - k2);
    double y = k1 * x + b1;

    Console.WriteLine($"Точка пересечения прямых - ({x}, {y})");
}

Console.Write("Напишите число b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Напишите число k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Напишите число b2: ");
double b2 = double.Parse(Console.ReadLine());
Console.Write("Напишите число k2: ");
double k2 = double.Parse(Console.ReadLine());

GetIfIntersectionLines(b1, k1, b2, k2);
