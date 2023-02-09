// Задача 34: Задайте массив, заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GenerateArray(int N)
{
    int[] array = new int[N];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] numbers)
{
    System.Console.WriteLine("[" + string.Join("; ", numbers) + "]");
}

int QuantityEvenNumbers(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            result+=1;
        }
    }
    return result;
}

int[] myArray = GenerateArray(4);
PrintArray(myArray);
System.Console.WriteLine($"Количество чётных чисел в массиве: " + QuantityEvenNumbers(myArray));


