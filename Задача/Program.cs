﻿// Напишите программу, которая на вход принимает
// число и выдает его квадрат (число умноженное
// на само себя).
// Например:
// ● 4 -> 16
// ● -3 -> 9
// ● -7 -> 49

Console.Clear();  

Console.Write("Введите число: ");  // выводит сообщения на экран !
int number = int.Parse(Console.ReadLine()!); // Console.ReadLine -все что написано с клавиатуры она выдергивает из консоли и вписывает в код(!-ставим этот знак чтобы не выскакивали желтые предуприждения
// int.Parse-преобразует из строки в целое число
// int number целочисленный контейнер 

int sqr = number*number;
double sqr2 = Math.Pow(number, 2);
Console.WriteLine($"Квадрат {number} равен {sqr}"); //$ -написанное перед строчкой делает ее умной 
Console.WriteLine($"Квадрат {number} равен {sqr2}");

