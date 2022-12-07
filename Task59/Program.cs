// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.

int[,] CreateMatrixRndInt(int line, int columns)
{
    int[,] matrix = new int[line, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
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
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}
int[] FindPositionMinElement(int[,] mass)
{
    int[] array = new int[2];
    int min = mass[0, 0];
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            if (mass[i, j] < min)
            {
                min = mass[i, j];
                array[0] = i;
                array[1] = j;
            }
        }
    }
    return array;
}
int[,] RemoveRowCol(int[,] matrix, int[] index)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int m = 0;
    int n = 0;
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if (m == index[0]) m++;

        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {

            if (n == index[1]) n++;
            newMatrix[i, j] = matrix[m, n];
            n++;
        }
        n = 0;
        m++;
    }
    return newMatrix;
}
int[,] matrix = CreateMatrixRndInt(4, 4);
PrintMatrix(matrix);
int[] array2D = FindPositionMinElement(matrix);
Console.Write("Позиция минимального элемента -> ");
PrintArray(array2D);
Console.WriteLine();
int[,] newM = RemoveRowCol(matrix, array2D);
PrintMatrix(newM);
