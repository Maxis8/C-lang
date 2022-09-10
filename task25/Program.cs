// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 01123
// Если N = 3 -> 011

int[] Fibonacci(int num)
{
    int[] fArray = new int[num];
    fArray[0] = 0;
    fArray[1] = 1;
    for(int i =2; i < num; i++)
    {
        fArray[i] = fArray[i-2] + fArray [i-1]; 
    }
    return fArray;
}
Console.Write("Введите число: ");
int fiNum = int.Parse(Console.ReadLine());
if (fiNum >= 2) Console.WriteLine(string.Join(" ", Fibonacci(fiNum)));
else if (fiNum == 1)Console.WriteLine("1");
else Console.WriteLine("incorrect number");