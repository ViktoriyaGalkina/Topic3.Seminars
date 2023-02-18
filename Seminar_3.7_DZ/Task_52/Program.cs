// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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
            matrix[i, j] = rand.Next(0, 11);
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

double[] ArithmeticMeanCols(int[,] matrix)
{
    double[] sum = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double arithmeticMean = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            arithmeticMean += matrix[i, j];
        }
        sum[j] = Math.Round(arithmeticMean /matrix.GetLength(0),1);
    }
    return sum;
}

void PrintMatrixDouble(double[] array)
    // for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Среднее арифметическое каждого столбца: " + string.Join("; ", array));
    }


int rows = ReadInt("Введите количество строк матрицы: ");
int cols = ReadInt("Введите количество столбцов матрицы: ");
System.Console.WriteLine();
var myMatrix = GenerateMatrix(rows, cols);
PrintMatrix(myMatrix);
System.Console.WriteLine();
double[] matr = ArithmeticMeanCols(myMatrix);
PrintMatrixDouble(matr);
