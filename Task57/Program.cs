// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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
int[] CreateOneFromTwo(int[,] mass)
{
    int y = 0;
    int[] newArray = new int[mass.Length];
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            newArray[y] = mass[i, j];
            y++;
        }

    }
    return newArray;
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
void PrintCount(int[] array)
{
    int count = 1;
    int num = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == num) count++;
        else
        {
            Console.WriteLine($"Число {num} встречается {count} раз.");
            num = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"Число {num} встречается {count} раз.");
}
int[,] matrix = CreateMatrixRndInt(3, 3);
PrintMatrix(matrix);
int[] array = CreateOneFromTwo(matrix);
PrintArray(array);
Array.Sort(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
PrintCount(array);
