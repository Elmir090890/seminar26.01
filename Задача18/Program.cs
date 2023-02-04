// Задача No18. Работа в группах
// Напишите программу, которая по заданному номеру
// четверти, показывает диапазон возможных координат
// точек в этой четверти (x и y).

Console.Clear();
Console.Write("Введите номер четверти: ");
int number = int.Parse(Console.ReadLine()!);

//  if (number==1)
//  {
//     Console.Write("Координаты X > 0 , Y > 0 ");
//  }

//  else if (number==2)
//  {
//     Console.Write("Координаты X < 0 , Y > 0 ");
//  }

//  else if (number==3)
//  {
//     Console.Write("Координаты X < 0 , Y < 0 ");
//  }


//  else if (number==4)
//  {
//     Console.Write("Координаты X > 0 , Y < 0 ");
//  }
//  else
//  {
//     Console.Write("Введите число от 1 до 4 ");
//  }

switch (number)
{
    case 1:
        Console.Write("X>0 , Y>0 ");
        break;

    case 2:
        Console.Write("X<0 , Y>0 ");
        break;
    case 3:
        Console.Write("X<0 , Y<0 ");
        break;
    case 4:
        Console.Write("X<0 , Y>0 ");
        break;
    default:
        Console.Write("Ввкдите число от 1 до 4 ");
        break;

}