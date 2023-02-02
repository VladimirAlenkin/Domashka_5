// Написать программу копирования массива
Console.WriteLine("Задача 4: написать программу копирования массива");
Console.WriteLine();

void FillArray(int[] arr)

{
    int Length = arr.Length;
    int index = 0;
    while (index < Length)
    {
        arr[index] = new Random().Next(1, 100);
        index++;
    }
}

void PrintArray(int[] arr)

{
    int Length = arr.Length;
    int index = 0;
    while (index < Length)
    {
        Console.Write(arr[index] + " ");
        index++;
    }
}

void CopyArray(int[] arr1, int[] arr2)

{
    int Length = arr1.Length;
    int index = 0;
    while (index < Length)
    {
        arr2[index] = arr1[index];
        index++;
    }
}

Console.WriteLine("Введите количество элементов массива");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];

FillArray(array);
Console.Write("Исходный массив: ");
PrintArray(array);

Console.WriteLine();

int[] copyarray = new int[n];
CopyArray(array, copyarray);
Console.Write("Массив - копия: ");
PrintArray(copyarray);
