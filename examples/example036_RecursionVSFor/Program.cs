// Сравнение рекурсии и итеративного подхода

decimal fRec = 0;
decimal fIte = 0;

decimal FibbonacciRecursion(int n)
{
    fRec++;
    return n == 0 || n == 1 ? 1 : FibbonacciRecursion(n-1) + FibbonacciRecursion(n-2);
}

decimal FibbonacciIteration(int n)
{
    fIte++;
    decimal result = 1;
    decimal f0 = 1;
    decimal f1 = 1;

    for (int i = 2; i <= n; i++) {
        result = f0 + f1;

        f0 = f1;
        f1 = result;
        fIte++;
    }

    return result;
}

DateTime dt = DateTime.Now;

for (int n = 10; n < 40; n++)
{
    Console.WriteLine($"FibbonacciIteration({n}) = {FibbonacciIteration(n)} fIte = {fIte.ToString("### ###")}");

    fIte = 0;
}

System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

Console.WriteLine();

dt = DateTime.Now;

for (int n = 10; n < 40; n++)
{
    Console.WriteLine($"FibbonacciRecursion({n}) = {FibbonacciRecursion(n)} fRec = {fRec.ToString("### ###")}");

    fRec = 0;
}

System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
