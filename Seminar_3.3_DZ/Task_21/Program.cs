// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Math.Pow(число,количество квадратов)
// Math.Sqrt(квадратный корень из указанного числа)


// 1 вариант.

// System.Console.WriteLine("Введите координату x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите координату y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите координату y1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите координату x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите координату y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите координату z2: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine($"Расстояние между точками в 3D пространстве: " + Math.Round(Math.Pow(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2), 0.5), 2));


// 2 вариант.

int InputNumber(string str) 
{
    System.Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = InputNumber("Введите координату Х1: ");
int y1 = InputNumber("Введите координату Y1: ");
int z1 = InputNumber("Введите координату Z1: ");

int x2 = InputNumber("Введите координату Х2: ");
int y2 = InputNumber("Введите координату Y2: ");
int z2 = InputNumber("Введите координату Z2: ");


System.Console.WriteLine($"Расстояние между точками в 3D пространстве: " + Math.Round(Math.Pow(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2),0.5),2));