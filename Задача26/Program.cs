// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


Console.Clear();

int NumLen(int A)
{
    int count = 0;
    while (A > 0)
    {
        A = A / 10;
        count = count + 1;
    }
    return count;
}

Console.WriteLine("Enter your Number: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Tne number of digits of your number {N} is {NumLen(N)}");