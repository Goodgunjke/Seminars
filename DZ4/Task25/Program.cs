// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите первое число(А)");

int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 2 число(B)");

int b = Convert.ToInt32(Console.ReadLine());
int cycle = a;

for (int i = 1; i < b; i++)
    {
    cycle *= a;
    }
Console.WriteLine("А в степени B равно: " + cycle);
