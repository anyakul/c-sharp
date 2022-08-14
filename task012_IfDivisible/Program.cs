// 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

Console.WriteLine("Введите два числа");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int result = num2 % num1;

if(result == 0) {
   Console.WriteLine($"Число {num2} кратно {num1}"); 
}

else {
   Console.WriteLine($"Число {num2} некратно {num1}, остаток от деления {result}"); 
}
