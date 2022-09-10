// Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные и наоборот.
 
int[] PrintNum(int size, int minValue,  int maxValue)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue); 
    }
    return res;
}

int[] ReversNum(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
    return array;
}


int[] printArray = PrintNum(12, -100, 100);
Console.WriteLine(string.Join(" ", printArray));
int[] reversnum = ReversNum(printArray);
Console.WriteLine(string.Join(" ", reversnum ));