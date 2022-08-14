/* 21) Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A(3, 6, 8); B(2, 1, -7) -> 15,84
A(7, -5, 0); B(1, -1, 9) -> 11,53
*/

Console.Write("Введите коорданиты точки x0: ");
int x0 = int.Parse(Console.ReadLine());
Console.Write("Введите коорданиты точки y0: ");
int y0 = int.Parse(Console.ReadLine());
Console.Write("Введите коорданиты точки z0: ");
int z0 = int.Parse(Console.ReadLine());
Console.Write("Введите коорданиты точки x1: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите коорданиты точки y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите коорданиты точки z1: ");
int z1 = int.Parse(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(x0 - x1, 2) + Math.Pow(y0 - y1, 2) + Math.Pow(z0 - z1, 2));

Console.WriteLine($"Рассотяние между двумя точами на плоскости равно {distance:f2}");
