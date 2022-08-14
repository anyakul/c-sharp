// 16) Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Console.WriteLine("Введите два числа");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int sqr1 = num1 * num1;
int sqr2 = num2 * num2;

if (sqr1 == num2 || sqr2 == num1 ) {
    Console.WriteLine("Да");
}

else {
    Console.WriteLine("Нет");
}
