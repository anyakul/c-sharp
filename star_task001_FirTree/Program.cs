// 1* Напишите функцию, которая принимает одно число - высоту елочки и рисует ее в консоли звездочками.

void GetFirTree(int count)
{
    int index = count;

    for(int i = 0; i <= count-1; i++)
    {
        for (int j = 1; j <= count+(count-1); j++)
        {
            Console.Write((j >= index && j <= index+i*2) ? "*" : " ");
        }

        index = index - 1;
        Console.WriteLine(" ");
    }
}

Console.Write("Напишите число: ");
int count = int.Parse(Console.ReadLine());
GetFirTree(count);
