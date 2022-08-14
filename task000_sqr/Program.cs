// 0) Напишите программу которая на вход принимает число и выдаёт его квадрат (число помноженное на само себя)

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int sqr = number * number;
Console.WriteLine($"Квадрат числа {number} - {sqr}");
