// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
// 6, 1, 33 -> [6, 1, 33]



int GetNumber(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GetArray(int[] size, int leftRange, int rightRange)
{
    var rand = new Random();
    for (int i = 0; i < size.Length; i++)
    {
        size[i] = rand.Next(leftRange, rightRange);
    }
    return size;
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

int A = GetNumber("Введите левую границу массива: ");
int B = GetNumber("Введите правую границу массива: ");
var arr = new int[8];
var myArray = GetArray(arr,A,B);
PrintArray(myArray);

