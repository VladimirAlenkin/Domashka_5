
//фибоначи
Console.WriteLine("Задача 2: показать числа Фибоначчи");
Console.WriteLine();
Console.WriteLine("Сколько элементов последовательности Фибоначи вы хотите увидеть? ");
int count = int.Parse(Console.ReadLine()!);
int[] array = new int[count];
array[0] = 0;
array[1] = 1;

for (int index = 2; index < count; index++)

    array[index] = array[index - 1] + array[index - 2];

for (int index = 0; index < count; index++)
{
    Console.Write(array[index] + " ");
}
