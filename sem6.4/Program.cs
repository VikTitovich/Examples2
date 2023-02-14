// var array = new int[] { 1, 2, 3, 4 };

// PrintArray(array);

// void PrintArray<T>(T[] array)          //метод вывода любых данных
// {
//     foreach (var item in array)
//     {
//         Console.WriteLine(item);
//     }
// }

// object[] array = new object[] {1, "", new Random()}; // массив с разными переменными

// Не используя рекурсию, выведите первые N чисел Фибоначчи
// Первые два числа Фибоначчи: 0 и 1
// N = 5 -> 0 1 1 2 3
// N = 3 -> 0 1 1 
// N = 7 -> 0 1 1 2 3 5 8

//int a = ReadInt("число");

Fibonacci(ReadInt("Number"));

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

// void Fibonacci(int a)
// {
//   int[] array = new int[a];
//   array[0] = 0;
//   array[1] = 1;

//   for (int i = 2; i < a; i++)
//   {
//     array[i] = array[i - 1] + array[i - 2];
//   }

//   Console.WriteLine(string.Join($"{Environment.NewLine}", array));
// }

void Fibonacci (int num)
{
    int[] arr = new int[num];
    if (num > 2)
    {
        arr[0] = 0;
        arr[1] = 1;
        for (int i = 2; i < num; i++)
        {
            arr[i] = arr[i-2] + arr[i -1];
        }
        Console.WriteLine(string.Join(" ", arr));
    }
    else
    {
        Console.WriteLine("Enter nuber > 2");
    }
}


