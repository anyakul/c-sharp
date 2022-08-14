// 1) Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго

Console.WriteLine("Введите первое число");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNumber = int.Parse(Console.ReadLine());
int sqr = secondNumber * secondNumber;

if (firstNumber == sqr ) {
    Console.WriteLine($"Да, число {firstNumber} является квадратом числа {secondNumber}");
}

else {
    Console.WriteLine($"Нет, число {firstNumber} не является квадратом числа {secondNumber}");
}
