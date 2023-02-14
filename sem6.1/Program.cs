//Напишите программу, которая перевернёт одномерный массив (последний элемент
//будет на первом месте, а первый на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]

int[] array = GetRandomArray(6, 1, 10);

Console.WriteLine($"[{string.Join(", ", array)}]");

int[] arr = TurnArray(array);

Console.WriteLine($"[{string.Join(", ", arr)}]");

int[] TurnArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temporary = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temporary;
    }
    return array;
}

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



