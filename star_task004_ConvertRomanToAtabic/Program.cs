/* 4*) Написать программу для перевода римских чисел в десятичные арабские
III -> 3
LVIII -> 58
MCMXCIV -> 1994
*/

string[] Rome = { "M", "D", "C", "L", "X", "V", "I" };
int[] Arab = { 1000, 500, 100, 50, 10, 5, 1 };

int ConvertRomanToArabic(string romanNumber)
{
    int size = romanNumber.Length;
    int[] num = new int[size];
    int result = 0;
    int i = 0;
    int j = 0;

    while (i < size)
    {
        if (i < size - 1)
        {
            j = i + 1;
        }

        num[i] = Arab[Array.IndexOf(Rome, $"{romanNumber[i]}")];
        num[j] = Arab[Array.IndexOf(Rome, $"{romanNumber[j]}")];

        if (num[i] < num[j])
        {
            result += num[j] - num[i];
            i += 2;
        }

        else if (num[i] >= num[j])
        {
            result += num[i];
            i++;
        }
    }

    return result;
}

Console.Write("Напишите римское число: ");
string romanNum = Console.ReadLine();
int result = ConvertRomanToArabic(romanNum);

Console.WriteLine($"Число {romanNum} в арабском виде будет {result}");
