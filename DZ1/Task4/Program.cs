//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел. 2, 3, 7 -> 7 ; 44 5 78 -> 78 ; 22 3 9 -> 22
int max = int.MinValue; 
for (int i = 0; i < 3; i++) 
{
   int num = Convert.ToInt32(Console.ReadLine()); 
   if (num > max)
      max = num; 
}
Console.WriteLine("максимальное число - "+ max  ); 
