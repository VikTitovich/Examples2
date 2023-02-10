// Найдите произведение пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишем в новом массиве.
// [1, 2, 3, 4, 5] -> 5 8 3


int[] array = GetRandomArray(6, 1, 10);

int[] newArray = GetProductOfPair(array);

Console.WriteLine($"[{string.Join(", ", array)}]");

Console.WriteLine($"[{string.Join(", ", newArray)}]");

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

int[] GetProductOfPair(int[] array)
{
    int length = 0;

    if (array.Length % 2 == 0)
    {
        length = array.Length / 2;
    }
    else
    {
        length = array.Length / 2 + 1;
    }

    int[] result = new int[length];

    for (int i = 0; i < length; i++)
    {
        result[i] = array[i] * array[array.Length - 1 - i];
    }

    if (array.Length % 2 != 0)
    {
        result[length - 1] = array[array.Length / 2];
    }

    return result;
}
