// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементом массива.

// [3 7 22 2 78] -> 76


double[] GetArray(int size, int leftRange, int rightRange)
{
    double[] array = new double[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round((rand.Next(leftRange, rightRange) + rand.NextDouble()), 2);
    }
    return array;
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("[" + string.Join("; ", array) + "]");
}


// ------------- 1 вариант.
double MinValue(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double MaxValue(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double[] MyArray = GetArray(4, 0, 20);
PrintArray(MyArray);
System.Console.WriteLine($"Максимальный элемент массива: " + Math.Round(MaxValue(MyArray), 2));
System.Console.WriteLine($"Минимальный элемент массива: " + Math.Round(MinValue(MyArray), 2));
System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива: " + Math.Round((MaxValue(MyArray) - MinValue(MyArray)), 2));


// ------------ 2 вариант.
// double[] Value(double[] array)
// {
//     double[] result = new double[2];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < array[0])
//         {
//             result[0] = array[i];
//         }
//         else
//         {
//             result[1] = array[i];
//         }
//     }
//     return result;
// }


// double[] MyArray = GetArray(4, 0, 20);
// PrintArray(MyArray);
// double[] MaxMin = Value(MyArray);
// System.Console.WriteLine($"Максимальный элемент массива: " + Math.Round(MaxMin[1], 2));
// System.Console.WriteLine($"Минимальный элемент массива: " + Math.Round(MaxMin[0], 2));
// System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива: " + Math.Round((MaxMin[1] - MaxMin[0]), 2));


