// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

void SumElements(int[] array, out int sumOddNumbers)
{
    sumOddNumbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            sumOddNumbers = sumOddNumbers + array[i];
        }
    }
}

int[] MyArray = GetArray(4, -100, 100);
PrintArray(MyArray);
SumElements(MyArray, out int sumOddNumbers);
System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sumOddNumbers}");



// --------2 вариант(не получается)  //Строка 46: "SumElements(int[])": не все пути к коду возвращают значение.
//                                    В чем может быть ошибка?(


// int SumElements(int[] array)
// {
//     int sumOddNumbers = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 == 1)
//         {
//             sumOddNumbers = sumOddNumbers + array[i];
//         }
//         return sumOddNumbers;
//     }
// }

// int[] MyArray = GetArray(4, -100, 100);
// PrintArray(MyArray);
// System.Console.WriteLine(SumElements(MyArray));


