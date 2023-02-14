// Напишите программу, которая будет создавать 
// копию заданного массива с помощью поэлементного копирования

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

int[] CopyArray(int[] array)
{
    int[] copyArray = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        copyArray[i] = array[i];
    }

    return copyArray;
}

void PrintNmbers(int[] array)
{
    Console.WriteLine(string.Join(", ", array));
}

int[] array = GetRandomArray(10, 0, 100);

PrintNmbers(array);

int[] newArr = CopyArray(array);

PrintNmbers(newArr);

