// 8) Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Напишите число:");
int number = int.Parse(Console.ReadLine());
int i = 2;

while(i<=number) {
    Console.WriteLine(i);
    i+=2;
}
