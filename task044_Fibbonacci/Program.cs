/* 44) Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */

int[] GetFibbonacci(int num) {
    int[] fib = new int[num];
    fib[0] = 0;
    fib[1] = 1;

    for (int i = 2; i < num; i++)
    {
        fib[i] = fib[i-1] + fib[i-2];
    }

    return fib;
}

Console.Write("Напишите число: ");
int num = int.Parse(Console.ReadLine());

int[] result = GetFibbonacci(num);

Console.WriteLine($"[{String.Join(" ", result)}]");
