
// Написать программу масштабирования фигуры
Console.WriteLine("Задача 3: написать программу масштабирования фигуры");
Console.WriteLine();
Console.WriteLine("Сколько вершин у фигуры?");
int n = int.Parse(Console.ReadLine()!);
int[,] matrix = new int[n, 2];
Console.WriteLine("Введите координаты (х,y) вершин фигуры");
for (int i = 0; i < n; i++)
{
    Console.Write("x(" + (i + 1) + ") = ");
    matrix[i, 0] = int.Parse(Console.ReadLine()!);
    Console.Write("y(" + (i + 1) + ") = ");
    matrix[i, 1] = int.Parse(Console.ReadLine()!);
}
Console.WriteLine();
Console.WriteLine("Исходные координаты вершин фигуры");

for (int i = 0; i < n; i++)
    Console.Write("(" + matrix[i, 0] + "," + matrix[i, 1] + ") ");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Задайте коэффицент масштабирования - k");
int k = int.Parse(Console.ReadLine()!);

for (int i = 0; i < n; i++)
{
    matrix[i, 0] = matrix[i, 0] * k;
    matrix[i, 1] = matrix[i, 1] * k;
}
Console.WriteLine();
Console.WriteLine("При k = " + k + " получаем координаты вершин");

for (int i = 0; i < n; i++)
    Console.Write("(" + matrix[i, 0] + "," + matrix[i, 1] + ") ");


