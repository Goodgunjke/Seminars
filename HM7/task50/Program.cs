// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите номер строки массива :");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер столбца массива :");
int m = Convert.ToInt32(Console.ReadLine());

int [,] numbers = new int [5,5];
FillArrayRandom(numbers);

    if (n > numbers.GetLength(0) && m > numbers.GetLength(1))
    {
        Console.WriteLine("Такого элемента нет в массиве");
    }
    else
    {
        Console.WriteLine($" Элемент массива [{n},{m}] = {numbers[n-1,m-1]}");
    }

PrintArray(numbers);

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i,j] = new Random().Next(1, 100);
        }   
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("\t" + array[i,j] + " ");
        }   
        Console.WriteLine(""); 
    }
}