// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


// double[] GetArray(int size)
// {
//     double[] array = new double[size];
//     var rand = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] =  Math.Round(rand.NextDouble()*100,2);
//     }
//     return array;
// }

// void PrintArray(double[] array)
// {
//     System.Console.WriteLine("[" + string.Join("; ", array) + "]");
// }

// double[] MyArray = GetArray(4);
// PrintArray(MyArray);



double[] GetArray(int size, int leftRange, int rightRange)
{
    double[] array = new double[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] =  Math.Round((rand.Next(leftRange, rightRange)+rand.NextDouble()),2);
    }
    return array;
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("[" + string.Join("; ", array) + "]");
}

double[] MyArray = GetArray(4,-10,10);
PrintArray(MyArray);