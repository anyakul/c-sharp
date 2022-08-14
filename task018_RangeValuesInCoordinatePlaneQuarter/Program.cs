// 18) Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти - от 1 до 4: ");
int quarter = int.Parse(Console.ReadLine());

switch (quarter) 
{
    case 1:
      Console.WriteLine("Диапозон возможных значений: x > 0, y > 0"); 
      break; 
    case 2:
      Console.WriteLine("Диапозон возможных значений: x < 0, y > 0");
      break; 
    case 3:
      Console.WriteLine("Диапозон возможных значений: x < 0, y < 0");
      break; 
    case 4:
      Console.WriteLine("Диапозон возможных значений: x > 0, y < 0");
      break; 
    default:
      Console.WriteLine("Такой четверти нет");
      break;
}
