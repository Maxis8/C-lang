// Напишите программу, которая на вход принимает чисор(А) и выдаёт сумму чисел от 1 до А.

int GetNums(int number)
{
    int sum = 0;
    for(int i = 1; i<=number; i++)
    {
        sum += i;
    }
    return sum; 
}
Console.WriteLine("Введите число:A ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"{GetNums(num)}");