// Напишите программу, которая на вход принимает число(N) и выдаёт таблицу квадратов чисел от 1 до N.


 Console.WriteLine("Введите число:");
 int num = int.Parse(Console.ReadLine());
 int count =1;
 while(count<=num)
 {
     Console.Write($"{count*count} ");
     count++;
 }
 Console.WriteLine();
for(int i=1; i<=num; i++)
Console.Write($"{i*i} ");
Console.WriteLine();






