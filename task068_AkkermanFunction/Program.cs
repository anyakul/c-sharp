/* 68) Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
n = 3, m = 2 -> A(n,m) = 29 */

int AkkermanFunction(int n, int m)
{
    if (n < 0 || m < 0)
    {
        return 0;
    }

    if (n == 0) {
        return m + 1;
    }

    if (m == 0) {
        return AkkermanFunction(n - 1, 1);
    }

    return AkkermanFunction(n - 1, AkkermanFunction(n, m - 1));
}

Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число m: ");
int m = int.Parse(Console.ReadLine());

int result = AkkermanFunction(n, m);

Console.WriteLine($"Результат функции Аккермана с числами {n} и {m} равен {result}");
