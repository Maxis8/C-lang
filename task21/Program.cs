// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.

int[] GetArray(int size, int minValue, int maxValue)
{
int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
    res[i] = new Random().Next(minValue, maxValue +1);
    }
return res;
}

int[] ProductionArray(int[] array)
{

int size = array.Length / 2;
if (array.Length % 2 != 0) size++;
int[] result = new int[size];

for (int i = 0; i < size; i++)
{
result[i] = array[i] * array[array.Length - 1 - i];
}
if (array.Length % 2 != 0) result[size - 1] = array[array.Length / 2];
return result;

}

int[] newArray = GetArray(5, 8, 9);
int[] changedArray = ProductionArray(newArray);
Console.WriteLine($"Массив: {String.Join(" ", newArray)}");
Console.WriteLine($"Результат: {String.Join(" ", changedArray)}");




