﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5  7    -2   -0,2
// 1   -3,3   8   -9,9
// 8    7,8  -7,1  9


int m = 3;
int n = 4;
Random rnd = new Random();
double[,] array = new double[m, n];
RandomArray(array);

void RandomArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rnd.NextDouble() * 20 - 10;
        }
    }
}
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write("\t" + Math.Round(array[i, j], 1) + " ");
        }
         Console.WriteLine();
    }
