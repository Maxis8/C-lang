// Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного копирования.


int[] GetArray(int size, int minValue, int maxValue)
{
int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
    res[i] = new Random().Next(minValue, maxValue +1);
    }
return res;
}

int[] CopyArray(int[] arr)
{
    int[]copy = new int [arr.Length];
    for(int i = 0;  i < arr.Length; i++)
    {
        copy[i] = arr[i];
    }
    return copy;

}


int[] myArray = GetArray(30, -10, 10);
Console.WriteLine($"Массив: {String.Join(" ", myArray)}");

Console.WriteLine($" Копия: {String.Join(" ", CopyArray(myArray))}");