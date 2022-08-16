// Показать текст переданный в функцию несколько раз
void Metod21(string msg, int count)
{
    int i = 0;
    while (i < count)
        {
            Console.WriteLine(msg);
            i++;
        }
    }
Metod21("Текст", 4);
