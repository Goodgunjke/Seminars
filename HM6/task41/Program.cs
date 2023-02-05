// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество элементов массива ");
int elementsCount = int.Parse(Console.ReadLine());
int[] myArray = new int[elementsCount];
   int count = 0;
     for (int i = 0; i < elementsCount; i++)
            {
                Console.WriteLine($"Введите {i} элемент массива ");
                int number = int.Parse(Console.ReadLine());

                if (number > 0)
                {
                    count++;
                }
            
            }
 Console.WriteLine("Количество чисел больше 0 равно " + count);
