Task_1();

void Task_1()
{
    int firstNumber = ReadInt ("First Number");

    int secondNumber = ReadInt ("Second Number");

    PrintMore (firstNumber, secondNumber);

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

// void PrintMore (int firstNumber, int secondNumber)
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

void PrintMore (int firstNumber, int secondNumber)
{
    Console.WriteLine(firstNumber > secondNumber ? firstNumber : secondNumber);
}

