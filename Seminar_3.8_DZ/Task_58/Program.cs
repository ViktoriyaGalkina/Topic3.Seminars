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
            matrix[i, j] = rand.Next(0,5);
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

int[,] MatrixMultiplication(int[,] M, int[,] N)
{
    if (M.GetLength(0) != N.GetLength(1))
    {
        System.Console.WriteLine("Перемножение матриц невозможно!Кол-во строк 1 матрицы должно быть равно кол-ву столбцов 2 матрицы.");
    }
    int[,] multi = new int[M.GetLength(0), N.GetLength(1)];
    for (int i = 0; i < M.GetLength(0); i++)
    {
        for (int j = 0; j < N.GetLength(1); j++)
        {
            for (int k = 0; k < M.GetLength(1); k++)
            {
                multi[i, j] += M[i, k] * N[k, j];
            }
        }
    }
    return multi;
}


int rowsA = ReadInt("Введите количество строк 1 матрицы: ");
int colsA = ReadInt("Введите количество столбцов 1 матрицы: ");
int rowsB = ReadInt("Введите количество строк 2 матрицы: ");
int colsB = ReadInt("Введите количество столбцов 2 матрицы: ");
var myMatrixA = GenerateMatrix(rowsA, colsA);
System.Console.WriteLine();
PrintMatrix(myMatrixA);
System.Console.WriteLine();
var myMatrixB = GenerateMatrix(rowsB, colsB);
PrintMatrix(myMatrixB);
System.Console.WriteLine();
System.Console.WriteLine($"Результирующая матрица: ");
PrintMatrix(MatrixMultiplication(myMatrixA, myMatrixB));
