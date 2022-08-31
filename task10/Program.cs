//Декарт, поиск диапозона x, y по четверти.

Console.WriteLine("Введите четверть: ");
int x = int.Parse(Console.ReadLine());
 if( x == 1) Console.Write(" x > 0, y > 0");
else if( x == 2) Console.Write(" x < 0, y > 0");
else if( x == 3) Console.Write(" x < 0, y < 0");
else if( x == 4) Console.Write(" x > 0, y < 0");
else Console.Write("not exist");