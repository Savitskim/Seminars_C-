// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int[,] CreateMatrixSpiral(int line, int columns)
{
    int[,] matrix = new int[line, columns];
    int start = 1;
    int startColums = 0;
    int endColums = matrix.GetLength(1) - 1;
    int startRows = 0;
    int endRows = matrix.GetLength(0) - 1;

    while (startColums <= endColums && startRows <= endRows)
    {
        for (int i = startColums; i <= endColums; i++)
        {
            matrix[startRows, i] = start;
            start++;
        }
        startRows++;
        for (int j = startRows; j <= endRows; j++)
        {
            matrix[j, endColums] = start;
            start++;
        }
        endColums--;
        for (int k = endColums; k >= startColums; k--)
        {
            matrix[endRows, k] = start;
            start++;
        }
        endRows--;
        for (int p = endRows; p >= startRows; p--)
        {
            matrix[p, startColums] = start;
            start++;
        }
        startColums++;
    }
    return matrix;
}
// matrix[0,0]=01;
// matrix[0,1]=02;
// matrix[0,2]=03;
// matrix[0,3]=04;

// matrix[1,3]=05;
// matrix[2,3]=06;
// matrix[3,3]=07;

// matrix[3,2]=08;
// matrix[3,1]=09;
// matrix[3,0]=10;

// matrix[2,0]=11;
// matrix[1,0]=12;

// matrix[1,1]=13;
// matrix[1,2]=14;

// matrix[2,2]=15;

// matrix[2,1]=16;
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10) Console.Write($" 0{matrix[i, j]}");
            else Console.Write($" {matrix[i, j]}");
        }
        Console.WriteLine(" |");
    }
}
int[,] matrix = CreateMatrixSpiral(4, 4);
PrintMatrix(matrix);