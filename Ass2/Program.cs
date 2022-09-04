// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8
Console.WriteLine("Enter m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matr = FillMatrix(m, n, -10, 10);
PrintMatrix(matr);
int[,] matrices = ToArray(matr);
Console.WriteLine();
PrintMatrix(matrices);

int[,] ToArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int b = 0; b < matrix.GetLength(1); b++)
            {
                if (matrix[i, j] < matrix[i, b])
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, b];
                    matrix[i, b] = temp;
                }
            }
        }
    }

    return matrix;

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