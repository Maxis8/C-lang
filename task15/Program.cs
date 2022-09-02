// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int Total(int num)
{ 

    int i = 1 ;
    int result = 1;
    while(i <= num)
   { 

      result = i * result;
      i++;
   }
    return result;
}


Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

 
Console.WriteLine($"{Total(number)}");