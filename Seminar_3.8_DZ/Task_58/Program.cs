// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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


int rowsA = ReadInt("Введите количество строк 1 матрицы: ");
int colsA = ReadInt("Введите количество столбцов 1 матрицы: ");
int rowsB = ReadInt("Введите количество строк 2 матрицы: ");
int colsB = ReadInt("Введите количество столбцов 2 матрицы: ");
var myMatrix = GenerateMatrix(rowsA, colsA);
System.Console.WriteLine();
PrintMatrix(myMatrix);
System.Console.WriteLine();
var myMatrixA = GenerateMatrix(rowsB, colsB);
PrintMatrix(myMatrixA);