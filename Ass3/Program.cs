// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.WriteLine("Enter m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix0 = FillMatrix(m, n, -10, 10);
PrintMatrix(matrix0);
Console.WriteLine();
int[,] matrix1 = FillMatrix(m, n, -10, 10);
PrintMatrix(matrix1);
Console.WriteLine();
int[,] multipliedMatrix = MultiplyMatrix(matrix0, matrix1);
PrintMatrix(multipliedMatrix);

int[,] MultiplyMatrix(int[,] matr1, int[,] matr2)
{
    int[,] multiplied = new int[matr1.GetLength(0), matr1.GetLength(1)];
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr1.GetLength(1); j++)
        {
            multiplied[i,j] = matr1[i,j]*matr2[i,j];
        }

    }
    return multiplied;
}




int[,] FillMatrix(int Rows, int Columns, int left, int right)
{
    int[,] matrix = new int[Rows, Columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }

}
