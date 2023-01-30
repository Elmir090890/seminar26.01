//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.WriteLine("Ведите число A: ");
int A = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);

Console.WriteLine("Ввудите число C: ");
int C = int.Parse(Console.ReadLine()!);

int max = A;
if (B> max ) max = B;
if (C> max ) max = C;

Console.Write("max ");
Console.WriteLine(max);


