/* 19) Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом 
14212 - нет, 
23432 - да */

Console.Write("Напишите пятизначное число: ");

int num = int.Parse(Console.ReadLine());

int a1 = num % 10;
int b1 = num / 10;
int a2 = b1 % 10;
int b2 = b1 / 100;
int a3 = b2 % 10;
int a4 = b2 / 10;

if (a1 == a4 && a2 == a3) {
    Console.WriteLine($"Число {num} является палиндромом");
}

else {
    Console.WriteLine($"Число {num} не является палиндромом");
}
