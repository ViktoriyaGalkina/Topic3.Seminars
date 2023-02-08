// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
// 6, 1, 33 -> [6, 1, 33]


int[] GetArray()
{
    int[] arr = new int[8];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(0, 2);
    }
    return arr;
}

void PrintArray(int[] arr)
    {
        System.Console.Write("[" + string.Join(", ", arr) + "]");
    }

var MyArray = GetArray();
PrintArray(MyArray);

