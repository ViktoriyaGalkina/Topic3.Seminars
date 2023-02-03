// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

System.Console.Write("Введите день недели: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n == 1)
{
    System.Console.WriteLine("Понедельник");
}
else if (n == 2)
{
    System.Console.WriteLine("Вторник");
}
else if (n == 3)
{
    System.Console.WriteLine("Среда");
}
else if (n == 4)
{
    System.Console.WriteLine("Четверг");
}
else if (n == 5)
{
    System.Console.WriteLine("Пятница");
}
else if (n == 6)
{
    System.Console.WriteLine("Суббота");
}
else if (n == 7)
{
    System.Console.WriteLine("Воскресенье");
}
else
{
    System.Console.WriteLine("Такого дня недели не существует");
}