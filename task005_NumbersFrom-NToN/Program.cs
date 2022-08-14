// 5) Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Напишите число:");
int number = int.Parse(Console.ReadLine());
int i = -number;

while (i <= number) {
    Console.WriteLine(i);
    i++;
}
