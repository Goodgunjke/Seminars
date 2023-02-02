// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите 2 числа, чтобы узнать, какое больше");

int a, b;

Console.WriteLine("Введите первое число (а) - ");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число (б) - ");
b = Convert.ToInt32(Console.ReadLine());
 
          
if (a > b)
{
Console.WriteLine($"Число {a} больше, чем {b}");
}
else if (a < b)
{
Console.WriteLine($"Число {a} меньше, чем {b}");
}
else 
{
Console.WriteLine($"Числа {a} и {b} равны");
}