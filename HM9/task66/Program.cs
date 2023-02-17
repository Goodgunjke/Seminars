// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30

int PrintNumbers(int M, int N)
{
    if(M > N)
    {
        return 0;
    }
    else 
    {
        return M + PrintNumbers(M + 1, N);
    }

}
int sum, M, N;
Console.WriteLine("Введите число  M:");
M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
N = Convert.ToInt32(Console.ReadLine());
sum = PrintNumbers(M,N);
System.Console.WriteLine("Сумма чисел в промежутке от  " + M + " до " + N +" = "+ sum);


