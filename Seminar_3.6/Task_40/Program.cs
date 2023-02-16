// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.


metka:                                                                   // Если условие не выполняется-программа возвращ ко вводу числа
System.Console.WriteLine("Введите 3 числа через пробел: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);   // Конверт - выводит заданный текст в нужный тип переменных!!!
                                                                         // {1},{2},{3} -> {1,2,3}
if (array.Length != 3)                                                   // != не равно
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