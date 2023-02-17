﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
    
Console.WriteLine("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Числа от {N} до 1 :");
PrintNumbers(N);
void PrintNumbers(int N)
{
  if (N == 0)
  return;

  System.Console.WriteLine(N);
  PrintNumbers(N - 1);
}  