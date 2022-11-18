// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.
Console.WriteLine("Введите координаты точки");
Console.Write("Введите X = ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y = ");
int y = Convert.ToInt32(Console.ReadLine());

int Quarter(int x1, int y1)
{
    if(x1>0 && y1>0) return 1;
    if(x1<0 && y1>0) return 2;
    if(x1<0 && y1<0) return 3;
    if(x1>0 && y1<0) return 4;
    return 0;
}

int xy = Quarter(x,y);
string result = xy > 0
        ? $"Указанные координаты соответствуют четверти -> {xy}"
        : "Введены некорректные координаты";

//Console.WriteLine($"Номер четверти {xy}");
Console.WriteLine(result);

