// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

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
            Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine("|");
    }
}
void ChangeParityInd(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i+=2)
    {
        for (int j = 0; j < array2D.GetLength(1); j+=2)
        {
            array2D[i,j]*=array2D[i,j];
        }
    }
}
int[,] array2D = CreateMatrixRndInt(5, 5);
PrintMatrix(array2D);
ChangeParityInd(array2D);
Console.WriteLine();
PrintMatrix(array2D);
