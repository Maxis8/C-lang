// Напишите задачу , которая принимает на вход координаты двух точек и находит расстояние между ними в 2d пространстве.

Console.WriteLine("Введите значение x1:");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение y1:");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение x2:");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение y2:");
int y2 = int.Parse(Console.ReadLine());
int sqr1 = (x1-x2) * (x1-x2);
int sqr2 = (y1-y2) * (y1-y2);
int sum = sqr1 + sqr2;
double result = Math.Sqrt(sum);
Console.WriteLine($"{result:f2}");