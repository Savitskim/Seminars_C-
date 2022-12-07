// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

int[,] CreateMatrixRndInt(int line, int columns)
{
    int[,] matrix = new int[line, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
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
            if (matrix[i, j] < 10) Console.Write($"{matrix[i, j],3}");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine("|");
    }
}
int[,] ReverseFirstEndLine(int[,] matrix)
{
    int i = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int temp = matrix[i, j];
        matrix[i, j] = matrix[matrix.GetLength(0) - 1, j];
        matrix[matrix.GetLength(0) - 1, j] = temp;
    }
    return matrix;
}
int[,] matr = CreateMatrixRndInt(3, 4);
PrintMatrix(matr);
Console.WriteLine();
int[,] reverse = ReverseFirstEndLine(matr);
PrintMatrix(reverse);