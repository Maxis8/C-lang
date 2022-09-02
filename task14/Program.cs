// Напишите программу которая принимает на вход число и выдаёт количество цифр в числе.

int Total(int num)
{ 

    int i = 0;
    while(num != 0)
   { 

      num=num / 10;
      i++;
   }
    return i;
}


Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

 
Console.WriteLine($"{Total(number)}");