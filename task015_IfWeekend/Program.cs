//15) Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

Console.WriteLine("Введите число от 1 до 7");
int num = int.Parse(Console.ReadLine());

if (num > 0 && num < 6) {
    Console.WriteLine($"День недели {num} будний");
}

else if (num == 6 || num == 7) {
    Console.WriteLine($"День недели {num} выходной");
}

else {
   Console.WriteLine($"Такого дня недели не существует"); 
}
