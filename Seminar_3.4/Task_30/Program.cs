// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         System.Console.Write($"{array[i]} ");
//     }
// }

// int[] FillArray(int size)
// {
//     int[] arrN = new int[size];
//     for (int i = 0; i < 8; i++)
//     {
//         arrN[i] = new Random().Next(0, 2);
//     }
//     return arrN;
// }

// int[] myArray = FillArray(8);
// PrintArray(myArray);




// int[] GetArray()
// {
//     var arr = new int[8];
//     var rand = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rand.Next(0, 2);
//     }
//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
// }

// var myArray = GetArray();
// PrintArray(myArray);




// ---------- Версия 2
void GetArray(int[] arr)
{
    var rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(0, 2);
    }
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

int[] myArray = new int[8];
GetArray(myArray);
PrintArray(myArray);