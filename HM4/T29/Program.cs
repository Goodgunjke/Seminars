// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите количество элементов массива ");
int elementsCount = int.Parse(Console.ReadLine());
int[] myArray = new int[elementsCount];

for (int i = 0; i < myArray.Length; i++)
{
  Console.Write($"Введите элемент {i}: ");
  myArray[i] = int.Parse(Console.ReadLine());
 }

Console.Write("[");
  for (int i = 0; i < myArray.Length; i++)
 {
   Console.Write(myArray[i] + ",");
 }
Console.Write("]");
   Console.ReadLine();
