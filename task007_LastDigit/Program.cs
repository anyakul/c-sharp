// 7) Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.Write("Напишите трёхзначное число:");
int number = int.Parse(Console.ReadLine());

Console.WriteLine(number % 10);
