﻿// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.

//  • 34, 5 -> не кратно, остаток 4 
//  • 16, 4 -> кратно

Console.Clear();

Console.Write("Введите два числа через пробел: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(','), Convert.ToInt32); 

int num1 = array[0];
int num2 = array[1];

if(num1 % num2 == 0)
{
    Console.WriteLine("кратно");
}
else
{
    Console.Write($"не кратно, остаток {num1 % num2}");
}