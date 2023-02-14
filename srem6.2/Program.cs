//Напишите программу, которая принимает на вход 3 числа
//и проверяет, может ли существовать треугольник со
//сторонами такой длины

int a = ReadInt("сторону треугольника");
int b = ReadInt("сторону треугольника");
int c = ReadInt("сторону треугольника");

CheckTriangle(a, b, c);

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

void CheckTriangle(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b)
    {
        Console.WriteLine($"Треугольник со сторонами: {a}, {b} и {c} может существовать");
    }
    else
    {
        Console.WriteLine($"Треугольник со сторонами: {a}, {b} и {c} не может существовать");
    }
}

