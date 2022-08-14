// 2) Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Напишите первое число:");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("Напишите второе число:");
int secondNumber = int.Parse(Console.ReadLine());

if (firstNumber > secondNumber) {
    Console.WriteLine($"Число {firstNumber} больше числа {secondNumber}");
}

else {
    Console.WriteLine($"Число {secondNumber} больше числа {firstNumber}");
}
