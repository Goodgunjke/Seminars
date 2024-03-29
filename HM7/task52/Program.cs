﻿// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int m = 3;
int n = 4;


int[,] array = new int[3, 4]
    {
        { 1, 4, 7, 2 },
        { 5, 9, 2, 3 },
        { 8, 4, 2, 4 }
    };
AverageEachColumn(array);
void AverageEachColumn(int[,] array)  
{    
    for (int j = 0; j < n; j++)
    {
        int sum = 0;
            for (int i = 0; i < m; i++)
            {
                sum += array[i, j];
            }
        double avg = (double)sum / m;
        Console.WriteLine("Среднее арифметическое столбца " + (j + 1) + " = " + Math.Round( avg , 2));
    }
}    