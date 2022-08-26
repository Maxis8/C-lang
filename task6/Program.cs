Console.WriteLine("Введите число1; ");
int num1 = int.Parse( Console.ReadLine());
Console.WriteLine("Введите число2; ");
int num2 = int.Parse( Console.ReadLine());
int ost = num1 % num2;

if (num1 % num2 == 0)
{
    Console.WriteLine("Кратно");
}    
else
{
    Console.WriteLine($"Не кратно {ost}");
}




