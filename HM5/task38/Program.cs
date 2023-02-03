// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
// [3 7 22 2 78] -> 76

int[] newArr = RandomArray(10);
PrintArray(newArr);
Console.WriteLine(max(newArr) - min(newArr));

int max(int[] arr)
{
    int maxNum = arr[1];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > maxNum
)
        {
            maxNum = arr[i];
        }
    }
    return maxNum;

}

int min(int[] arr)
{
    int minNum = arr[1];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < minNum)
        {
            minNum = arr[i];
        }
    }
    return minNum;
}

int[] RandomArray(int length)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(1, 1000);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        System.Console.Write($"{item}, ");
    }
    System.Console.WriteLine();
}
