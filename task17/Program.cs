// Задайте массив из 12 элементов, заполненный случайными числами из промежутка[-9,9].
// Найдите сумму отрицательных и положительных элементов массива.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}


int[] PositiveAndNegativeSum(int[] array) 
{
    int[] res = new int[2];

    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            res[0] += array[i];
        }
        else
        {
            res[1] += array[i];       
        }
    }
    return res;
}
void PositiveSum(int[] array) // "foreach"
{
    int positivesum = 0;

    foreach(int el in array)
    {
        positivesum += el > 0 ? el : 0; // "foreach"
    }
    Console.WriteLine($"{positivesum}");
}   
int[] myArray = GetArray(10, -9, 9);
int[] result = PositiveAndNegativeSum(myArray);
Console.WriteLine(string.Join(" ", myArray));
Console.WriteLine(string.Join(", ", result)); 
PositiveSum(myArray);
