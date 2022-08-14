// 4) Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Напишите первое число:");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("Напишите второе число:");
int secondNumber = int.Parse(Console.ReadLine());
Console.Write("Напишите третье число:");
int thirdNumber = int.Parse(Console.ReadLine());
int max = firstNumber;

if (secondNumber > max) {
    max = secondNumber;
}

if (thirdNumber > max) {
    max = thirdNumber;
}

Console.WriteLine(max);
