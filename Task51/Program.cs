// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.

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
// int SumMainDiagonal(int[,] array2D)
// {
//     int count = 0;
//     for (int i = 0; i < array2D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2D.GetLength(1); j++)
//         {
//             if (i == j) count += array2D[i, j];
//         }
//     }
//     return count;
// }
int SumMainDiagonal(int[,] array2D)
{
    int count = 0;
    for (int i = 0; i < array2D.GetLength(0) && i < array2D.GetLength(1); i++)
    {
        count += array2D[i, i];
    }
    return count;
}

int[,] array2D = CreateMatrixRndInt(4, 4);
PrintMatrix(array2D);
int sumDiagonal = SumMainDiagonal(array2D);
Console.Write($"Сумма чисел на главной диагонали = {sumDiagonal}");

