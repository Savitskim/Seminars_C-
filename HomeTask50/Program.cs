// Задача 50. Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет
int[,] CreateMatrixRndInt(int line, int columns, int min, int max)
{
    int[,] matrix = new int[line, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],2} |");
        }
        Console.WriteLine();
    }
}
bool FindElement(int[,] arr, int row, int column)
{
    return row <= arr.GetLength(0) && column <= arr.GetLength(1) && row > 0 && column > 0;
}
int[,] array2D = CreateMatrixRndInt(7, 7, 0, 10);
Console.Write("Введите номер строки -> ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца -> ");
int columns = Convert.ToInt32(Console.ReadLine());
PrintMatrix(array2D);
bool result = FindElement(array2D, rows, columns);
Console.Write($"{rows},{columns} -> ");
Console.WriteLine(result ? array2D[rows - 1, columns - 1] : "такого элемента в массиве нет");