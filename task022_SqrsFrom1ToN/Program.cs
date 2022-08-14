/* 22) Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25
2 -> 1, 4
*/
Console.Write("Напишите число: ");

int number = int.Parse(Console.ReadLine());
int i = 1;

for (i = 1; i <= number; i++) {
    Console.Write(Math.Pow(i, 2) + ", ");
}
