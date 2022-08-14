/* 20) Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A(3, 6); B(2, 1) -> 5,09
A(7, -5); B(1, -1) -> 7,21
*/

Console.Write("Введите коорданиты точки x0: ");
int x0 = int.Parse(Console.ReadLine());
Console.Write("Введите коорданиты точки y0: ");
int y0 = int.Parse(Console.ReadLine());
Console.Write("Введите коорданиты точки x1: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите коорданиты точки y1: ");
int y1 = int.Parse(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(x0 - x1, 2) + Math.Pow(y0 - y1, 2));

Console.WriteLine($"Рассотяние между двумя точами на плоскости равно {distance:f2}");
