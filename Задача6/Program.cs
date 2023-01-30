//  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
//  (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();
Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine()!);
if (n % 2 == 0)
{
    Console.WriteLine("Это четное число!");
}
else
{
    Console.WriteLine("Это НЕчетное число!");
}