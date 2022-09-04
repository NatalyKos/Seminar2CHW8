// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
// наименьшей суммой элементов: 1 строка

int[,] array = new int[5,2];

for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(0,5);
        Console.Write($"{array[i,j]} {" "}");
    }
    Console.WriteLine();
}

int[] RowSum(int[,] matr)
{
    int[] array = new int[matr.GetLength(0)];
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            sum = sum + matr[i,j];
        }
        array[i] = sum;
        }

    return array;
}
int[] Array = RowSum(array);
int minI = 0;
for(int i = 0; i < Array.Length; i++)
{
    if(Array[i] < Array[minI])
    {
        minI = i;
    }
}
Console.WriteLine($"The row with the smallest sum of elements is {minI}");
