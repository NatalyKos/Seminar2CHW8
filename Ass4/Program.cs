// Задача 60. Сформируйте трёхмерный массив из случайных неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Например:
//массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

int[,,] cube = FillMatrix(2,2,3,10,11);
CheckUnique(cube);

void CheckUnique(int[,,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            for(int k = 0; k < matr.GetLength(2); k++)
            {
                for(int l = 0; l < matr.GetLength(2); l++)
                {
                    if(matr[i,j,k] == matr[i,j,l])
                    {
                        matr[i,j,k] = new Random().Next(10,99);
                    }

                }
                Console.WriteLine($"{matr[i,j,k]} ({i}, {j}, {k})");
            }
        }
        
    }
}

int[,,] FillMatrix(int left, int middle, int right, int min, int max)

{
    int[,,] matrix = new int[left, middle, right];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i,j,k] = new Random().Next(10,99);
                //Console.WriteLine($"{matrix[i,j,k]} ({i}, {j}, {k})");
            }
        }
    }
    return matrix;
}