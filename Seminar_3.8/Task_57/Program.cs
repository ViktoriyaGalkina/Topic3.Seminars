// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
//  Набор данных
// Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза 
// 1 встречается 1 раз 
// 2 встречается 1 раз 
// 8 встречается 1 раз 
// 9 встречается 3 раза


// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза


int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

// void Chastota(int[,] matrix)
// {

//     for (int l = 0; l < 10; l++)
//     {
//         int count = 0;
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 // count = (l == matrix[i, j]) ? count++ : count + 0;
//                 if (l == matrix[i, j]) count++;
//             }
//         }
//         if (count > 0)
//         {
//             System.Console.WriteLine($"{l} встречаетмя {count} раз");
//         }
//     }
// }

int[] Chastota(int[,] matrix)
{
    var count = new int[10];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            count[matrix[i, j]]++;
        }
    }
    return count;
}

void PrintData(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] != 0)
        {
            System.Console.WriteLine($"{i} значение встречается {arr[i]} раз");
        }
    }
}
int rows = ReadInt("Введите количество строк матрицы: ");
int cols = ReadInt("Введите количество столбцов матрицы: ");

var myMatrix = GenerateMatrix(rows, cols);
PrintMatrix(myMatrix);
PrintData(Chastota(myMatrix));





// // Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// int m = ReadInt("Укажите количество строк: ");
// int n = ReadInt("Укажите количество столбцов: ");
// var myMatrix = GenerateMatrix(m, n);
// PrintMatrix(myMatrix);
// PrintResult(GetArray(myMatrix));


// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[,] GenerateMatrix(int rows, int cols)
// {
//     int[,] matrix = new int[rows, cols];
//     var rand = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rand.Next(0, 100000);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     System.Console.WriteLine("Сгенерирована матрица:");
//     System.Console.WriteLine();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// int[] GetArray(int[,] matrix)
// {
//     int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1)];
//     int count = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             array[count] = matrix[i, j];
//             count++;
//         }
//     }
//     return array;
// }

// void PrintResult(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == 0)
//         {
//             count++;
//         }
//     }
//     System.Console.WriteLine($"Число 0 встречается {count} раз");

//     int number = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         number = array[i];
//         count = 0;
//         if (number == 0)
//         {
//             continue;
//         }
//         for (int j = 0; j < array.Length; j++)
//         {
//             if (array[j] == number)
//             {
//                 count++;
//                 array[j] = 0;
//             }
//         }
//         System.Console.WriteLine($"Число {number} встречается {count} раз");
//     }

//     // for (int i = 0; i < array.Length; i++)
//     // {

//     // }

// }