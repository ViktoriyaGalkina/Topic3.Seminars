// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.

int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1); 
    }
    return array;
}

void ChangePositiveAndNegative(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i]; 
    }
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}


int[] myArray = GenerateArray(6, -9, 9);
PrintArray(myArray);
ChangePositiveAndNegative(myArray);
PrintArray(myArray);



