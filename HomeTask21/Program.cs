// Задача 21
// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние 
// между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координаты первой точки A(X1,Y1,Z1) -> ");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты второй точки B(X2,Y2,Z2) -> ");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double z2 = Convert.ToDouble(Console.ReadLine());

double Distance3D(double xa, double ya, double za, double xb, double yb, double zb)
{
    return Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
}

double cube = Distance3D(x1, y1, z1, x2, y2, z2);
double result = Math.Round(cube, 2, MidpointRounding.ToZero);
Console.WriteLine($"A ({x1},{y1},{z1}); B({x2},{y2},{z2}), -> {result}");
