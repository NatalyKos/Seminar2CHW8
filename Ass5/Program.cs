// Задача 62. Заполните спирально массив 4 на 4.


Console.WriteLine("Enter m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matr = FillMatrix(m, n, 0, 10);
PrintMatrix(matr);


int[,] FillMatrix(int Rows, int Columns, int left, int right)
{
    int[,] matrix = new int[Rows, Columns];
    int count = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++) 
        {
            matrix[i,j] = count;
            count++;
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++) 
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }

}