//Напишите программу, которая будет преобразовывать
//десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int a = ReadInt("число");

Console.WriteLine(TransformNumber(a));

int ReadInt(string arg)
{
    int i;
    Console.Write($"Введите {arg}: ");

    while (!int.TryParse(Console.ReadLine(), out i))
    {
        Console.Write("Неверное значение. Повторите: ");
    }

    return i;
}

string TransformNumber(int a)
{
    string result = String.Empty;
    while (a > 0)
    {
        result = a % 2 + result;

        a /= 2;
    }
    return result;
}