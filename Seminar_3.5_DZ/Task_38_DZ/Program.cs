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


double[] MyArray = GetArray(4, 0, 20);
PrintArray(MyArray);


int Max = 0;
int[] arr = new int[MyArray];
for(int i = 0; i < arr.Length-1; i++) //-1
{
    int minPosition = j;
    for(int j = i+1;j< arr.Length; j++)
    {
         if (arr[j] < arr[minPosition])
            {
                minPosition = j;
            }
    }
}



// void selectionSort(double[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[minPosition])
//             {
//                 minPosition = j;
//             }
//         }
//         double temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }





// selectionSort(MyArray);






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