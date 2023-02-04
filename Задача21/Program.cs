// Задача No21. Работа в группах
// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между
// ними в 2D пространстве.
// ● A (3,6); B (2,1) -> 5,09
// ● A (7,-5); B (1,-1) -> 7,21

Console.Clear();
Console.Write("Введите координат X1:");
int X1 = int.Parse(Console.Readline()!);

Console.Write("Введите координат Y1:");
int Y1 = int.Parse(Console.Readline()!);

Console.Write("Введите координат X2:");
int X2 = int.Parse(Console.Readline()!);

Console.Write("Введите координат Y2:");
int Y2 = int.Parse(Console.Readline()!);

double X = Math.Pow( X1-Y1, 2)+ Math.Pow(X1-Y2, 2);

// AB = √((xb - xa)^2 + (yb - ya)^2).

Console.Clear();

Console.Write("Введите координаты точки Xa: ");
int Xa = int.Parse(Console.ReadLine()!);
Console.Write("Введите координаты точки Ya: ");
double Ya = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите координаты точки Xb: ");
double Xb = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите координаты точки Xb: ");
double Yb = Convert.ToDouble(Console.ReadLine()!);

double x = Math.Pow(Xb - Xa, 2) + Math.Pow(Yb - Ya, 2);

double len = Math.Sqrt(x);



Console.WriteLine($"{len:f2}");
