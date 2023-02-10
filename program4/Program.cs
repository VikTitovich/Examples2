// Напишите программу замены элементов массива: положительные замените на соответсвующие отрицательные,
// и наоборот. 
// [-4, -8, 8, 2] > [ 4, 8, -8, -2]

int[] array = GetRandomArray(4, -9, 10);

int[] changedArray = ChangeMarks(array);

Console.WriteLine($"[{string.Join(", ", array)}] - [{string.Join(", ", changedArray)}]");

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

int[] ChangeMarks(int[] array)
{
    int[] changed = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        changed[i] = array[i] * -1;
    }

    return changed;
}
