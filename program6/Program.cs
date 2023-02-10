// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат 
// в отрезке [10, 99]
// [5, 18, 123, 6, 2] -> 1

int[] array = GetRandomArray(123, -150, 150);

int count = GetCount(array);

Console.WriteLine($"In Your Array [{string.Join(", ", array)}] : {count} elements from 10 before 99");

int[] GetRandomArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];

    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

int GetCount(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        {
            count++;
        }
    }
    return count;
}
