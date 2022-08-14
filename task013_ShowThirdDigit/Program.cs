// 13) Напишите программу, которая выводит третью цифру заданного число или сообщает что третьей цифры нет.

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
int a1 = num / 100;
int a2 = a1 % 10;

if (num > 99 || num < -99) {
    Console.WriteLine($"Третья цифра числа {num} - {a2}");
}

else {
   Console.WriteLine($"Третьей цифры у числа {num} нет"); 
}
