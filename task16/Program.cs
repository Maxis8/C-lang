// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и еденицами в случайном порядке.

int[] IntArray()
{    
    int[] arr = new int [8];
    for(int i=0; i<arr.Length; i++)
    { 
        arr[i] = new Random().Next(0, 2);
    }
    return arr;    
 
}
 
 void Readarray(int[] arr)
{
    
    for(int i=0; i<arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine();

}
Readarray(IntArray());
Console.WriteLine(String.Join(", ", IntArray()));
