//Задайте массив из  12 элементов, заполненный случайными числами из промежутка [-9,9]. 
//Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
//сумма отрицательных равна -20

int[] array = GetRandomArray(4, -9, 10);

int[] minAndMax = GetMinAndMaxFromArray(array);

Console.WriteLine($"Entered Array {string.Join(" ", array)}");

Console.WriteLine($"sum + {minAndMax[0]}, sum - {minAndMax[1]}");


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

int[] GetMinAndMaxFromArray(int[] array)
{
 int[] minAndMax = new int[2];

 for (int i = 0; i < array.Length; i++) 
 { 
   if (array[i] > 0)
   {
     minAndMax[0] += array[i];
   }
   else
   {
     minAndMax[1] += array[i];
   }
 }
 return minAndMax;
}