//  Задача 15: Напишите программу, которая принимает на вход цифру, 
//  обозначающую день недели, и проверяет, является ли этот день выходным.


// 6 -> да 
// 7 -> да 
// 1 -> нет

System.Console.WriteLine("Введите номер дня недели: ");
int week = Convert.ToInt32(Console.ReadLine());

if (week > 0 && week <= 5)
{
    System.Console.WriteLine("Этот день не выходной(");
}
else if (week == 6 || week == 7)
{
    System.Console.WriteLine("Этот день ВЫХОДНОЙ!!!");
}
else
{
    System.Console.WriteLine("Вы ввели неверный номер дня недели!Введите номер от 1 до 7.");
}