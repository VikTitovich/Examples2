// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] > нет
// -3; массив [6, 7, 19, 345, 3] > да

int[] array = GetRandomArray(5, -9, 9);

int number = -5;

if (FindANumber(array, number))
{
    Console.WriteLine($"[{string.Join(", ", array)}] :  YES");
}
else
{
    Console.WriteLine($"[{string.Join(", ", array)}] :  NO");
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

bool FindANumber(int[] array, int number)
{
    if (number < 0) number *= -1;

    for (int i = 0; i < array.Length; i++)
    {
        int module = array[i];

        if (module < 0) module *= -1;

        if (module == number)
        {
            return true;
        }
    }
    return false;
}