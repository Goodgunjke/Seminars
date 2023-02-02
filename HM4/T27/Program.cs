// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

System.Console.WriteLine("Введите число, чтобы посчитать сумму цифр в числе  ");
int numA = Convert.ToInt32(Console.ReadLine());

  int Sum(int numA)
  {
    int count = Convert.ToString(numA).Length;

    int go = 0;

    int result = 0;

    for (int i = 0; i < count; i++)
    {
      go = numA - numA % 10;
      result = result + (numA - go);
      numA = numA / 10;
    }
   return result;
  }

int sumNumbers = Sum(numA);

Console.WriteLine("Сумма цифр в числе = " + sumNumbers);