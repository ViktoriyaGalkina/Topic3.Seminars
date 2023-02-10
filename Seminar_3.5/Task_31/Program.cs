// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1); // -9, 9 + 1
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

// int SumNegative(int[] array)
// {
//     int result = 0;
//     for(int i = 0; i<array.Length; i++)
//     {
//         if(array[i]<0)
//         {
//             result+=array[i];
//         }
//     }
//     return result;
// }

// int SumPositive(int[] array)
// {
//     int result = 0;
//     for(int i = 0; i<array.Length; i++)
//     {
//         if(array[i]>0)
//         {
//             result+=array[i];
//         }
//     }
//     return result;
// }




// 2 вариант.
// int[] SumNegativeAndPositive(int[] array)     // Сумму находим через создание нового массива и там будут лежать дваа значения.
// {
//     int[] result = new int[2];                // Задаем массив,который хранит 2 элемента с суммой мин и макс значений.
//     for (int i = 0; i < array.Length; i++)     // Изначально массив заполнен нулями.
//     {
//         if (array[i] < 0)
//         {
//             result[0] += array[i];
//         }
//         else
//         {
//             result[1] += array[i];
//         }
//     }
//     return result;
// 



// 3 вариант с out int.

void SumNegativeAndPositive(int[] array, out int sumPositive, out int sumNegative)
{
    sumNegative = 0;
    sumPositive = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sumNegative += array[i];
        }
        else
        {
            sumPositive += array[i];
        }
    }
}

int[] myArray = GenerateArray(6, -9, 9);
PrintArray(myArray);
SumNegativeAndPositive(myArray, out int sumPositive, out int sumNegative);
System.Console.WriteLine($"Сумма отрицательных элементов равна {sumNegative}");
System.Console.WriteLine($"Сумма положительных элементов равна {sumPositive}");