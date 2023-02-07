//Task_1();
Task_2();

// void Task_1()
// {
//     int firstNumber = ReadInt ("First Number");
//     int secondNumber = ReadInt ("Second Number");

//     PrintMoreFromTwo (firstNumber, secondNumber);

// }

void Task_2()
{
    int[] array = new int[] {ReadInt("First Number"), ReadInt("Second Number"), ReadInt ("Third Number") };

    PrintMoreFromArray(array);  
}

int ReadInt (string argument)
{
    Console.WriteLine($"Input {argument}");
    int number;

    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Error! Try again.");
    }
return number;
}

// void PrintMoreFromTwo (int firstNumber, int secondNumber)
// {
//     if (firstNumber > secondNumber)
//     {
//         Console.WriteLine($"{firstNumber} > {secondNumber}");
//     }
//     else
//     {
//         Console.WriteLine($"{secondNumber} > {firstNumber}");
//     }
// }

// void PrintMoreFromThree (int firstNumber, int secondNumber, int thirdNumber)
// {
//     int max = firstNumber;

//     if (secondNumber > max)
//     {
//         max = secondNumber;
//     }

//     if (thirdNumber > max)
//     {
//         max = thirdNumber;
//     }
//     Console.WriteLine($"The bigger number is {max}");
// }

void PrintMoreFromArray (int[] array)
{
    int max = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    } 
    Console.WriteLine($"The bigger number is {max}");
} 


