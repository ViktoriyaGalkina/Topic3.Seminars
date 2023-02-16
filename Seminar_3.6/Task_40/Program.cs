// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.


System.Console.WriteLine("Введите числа: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);   // Конверт - выводит заданный текст в нужный тип переменных!!!
                                                                         // {1},{2},{3} -> {1,2,3}
if (array.Length != 3)
{
    System.Console.WriteLine("Массив введён некоректно ");
    goto metka;
}

if ((array[0] + array[1]) > array[2] && (array[1] + array[2]) > array[0] && (array[0] + array[2] > array[1]))
{
    System.Console.WriteLine("Такой треугольник существует ");
}
else
{
    System.Console.WriteLine("Такой треугольник не существует ");
}