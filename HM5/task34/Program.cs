// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] newArr = RandomArray(4);
PrintArray(newArr);


Console.WriteLine(evenNumbers(newArr));


int evenNumbers(int[] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}




     int[]RandomArray(int length)
    {
    int[]arr = new int[length];
    
     for(int i = 0; i < length; i++)
     {
         arr[i] = new Random().Next(100,1000);
     }
     return arr;
    }

void PrintArray(int[] arr)
{
    
    foreach(int item in arr)
    {
        System.Console.Write($"{item}, ");
    } 
    System.Console.WriteLine();
}