// See https://aka.ms/new-console-template for more information

double Fibbonacci(int n)
{
    if (n == 1 || n == 2)
    {
        return 1;
    }

    else
    {
        return Fibbonacci(n-1) + Fibbonacci(n-2);
    }
}

for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i} = {Fibbonacci(i)}");
}
