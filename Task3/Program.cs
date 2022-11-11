Console.WriteLine("Введите число: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 1)
{
    Console.WriteLine("1.Понедельник");
}
else if (day == 2)
{
    Console.WriteLine("2.Вторник");
}
else if (day == 3)
{
    Console.WriteLine("3.Среда");
}
else if (day == 4)
{
    Console.WriteLine("4.Четверг");
}
else if (day == 5)
{
    Console.WriteLine("5.Пятница");
}
else if (day == 6)
{
    Console.WriteLine("6.Суббота");
}
else if (day == 7)
{
    Console.WriteLine("7.Воскресенье");
}
else
{
    Console.WriteLine("Число внедиапазона");
}