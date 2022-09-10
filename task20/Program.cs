// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке[10,99]. 

 
int[] GetArray(int size, int minValue, int maxValue)
{
int[] res = new int[size];

for (int i = 0; i < size; i++)
{
res[i] = new Random().Next(minValue, maxValue + 1);
}
return res;
}

int Elcount( int[] arr)
{
    int counter = 0;
foreach (var item in arr)
{
if (item >=10 && item <= 99)
    counter++;
}
return counter;
}



int[] myArray = GetArray(123, -100, 100);
Console.WriteLine(String.Join(" ", myArray));

int result = Elcount(myArray);
Console.WriteLine($"Колличество чисел из диапазона: {result}");