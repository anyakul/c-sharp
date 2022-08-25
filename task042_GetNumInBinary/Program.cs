/* 42) Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10 */

int GetNumInBinary(int num) {
    string result = "";

    while (num > 0)
    {
        result += Convert.ToString(num % 2);
        num /= 2;
    }

    result.ToCharArray().Reverse();

    return int.Parse(result);
}

Console.Write("Напишите число: ");
int num = int.Parse(Console.ReadLine());

int result = GetNumInBinary(num);

Console.WriteLine($"Число {num} в двоичной системе равна {result}");
