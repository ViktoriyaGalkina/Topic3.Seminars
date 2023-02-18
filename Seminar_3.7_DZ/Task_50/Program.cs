//  Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет


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

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FindElement(int[,] matr, int rows, int cols)
{
    if (rows < matr.GetLength(0) && cols < matr.GetLength(1))
    {

        System.Console.WriteLine($"Значение запрошенного элемента: " + matr[rows, cols]);
    }
    else
    {
        System.Console.WriteLine($"Числа с координатами " + (rows, cols) + " в массиве нет");
    }
}


int[,] myMatrix = GenerateMatrix(4, 4);
int rows = ReadInt("Введите позицию строки матрицы,начиная с 0: ");
int cols = ReadInt("Введите позицию столбца матрицы,начиная с 0: ");
PrintMatrix(myMatrix);
System.Console.WriteLine();
FindElement(myMatrix,rows,cols);