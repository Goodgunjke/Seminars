// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] newArr = RandomArray(4);
PrintArray(newArr);


Console.WriteLine(sumOddElements(newArr));


int sumOddElements(int[] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if( i % 2 != 0)
        {
            sum = sum + arr[i];
        }
    }
    return sum;
}


     int[]RandomArray(int length)
    {
    int[]arr = new int[length];
    
     for(int i = 0; i < length; i++)
     {
         arr[i] = new Random().Next(1,1000);
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