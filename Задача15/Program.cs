// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите число от 1 до 7: ");
int number = int.Parse(Console.ReadLine()!);
if (number > 0 && number < 8)
{
    if (number ==6 || number == 7)
    {
        Console.Write("Да ");
    }
    else 
    Console.Write("Нет ");
}
else
Console.Write("Вы ввели число не в пределах от 1 до 7, поэтому не возможно определить ");

