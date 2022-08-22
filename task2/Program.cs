Console.Write("Введите  число: ");
int d = int.Parse(Console.ReadLine());
if (0 < d && d < 8)
{ 
    if (d == 1) Console.WriteLine("Понедельник");
    else if (d == 2) Console.WriteLine("Ыторник");
    else if (d == 3) Console.WriteLine("Среда");
    else if (d == 4) Console.WriteLine("Четверг");
    else if (d == 5) Console.WriteLine("Пятница");
    else if (d == 6) Console.WriteLine("Суббота");
    else if (d == 7) Console.WriteLine("Воскресенье");
} 
else
{ 
    Console.WriteLine("Не существует");
} 
