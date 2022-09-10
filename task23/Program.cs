// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.
int[] GetArray(int size, int minValue, int maxValue)
{
   int[]res = new int[size];
   for (int i = 0; i < size; i++)
   {
       res[i] = new Random().Next(minValue, maxValue + 1);
   }
   return res;
}


    
    
    bool Triangle(int[] arr)
    {
       
        int a = arr[0];
        int b = arr[1];
        int c = arr[2];
        
        return a+b>c && a+c>b && b+c>a;
            
    }
   
    
int[]myArray =GetArray(3, 0, 10);
Console.Write(String.Join(" ", myArray));
Console.WriteLine();
if (Triangle( myArray)) Console.WriteLine("Треугольник существует");
else Console.WriteLine("Треугольник не существует");


// Альтернатива

// bool Triangle(int a, int b, int c)
// {
//     return (a+b>c && a+c>b && b+c>a);
// }



// Console.Write("Введите a: ");
// int num1 = int.Parse(Console.ReadLine());
// Console.Write("Введите b: ");
// int num2 = int.Parse(Console.ReadLine());
// Console.Write("Введите c: ");
// int num3 = int.Parse(Console.ReadLine());
// if (Triangle(num1, num2, num3 )) Console.WriteLine("Треугольник существует");
// else Console.WriteLine("Треугольник не существует");
