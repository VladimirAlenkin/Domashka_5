// //Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
Console.WriteLine("Задача 1: Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine();
Console.WriteLine("Введите значение k1 ");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение b1  ");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение k2 ");
double k2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение b2  ");
double b2 = double.Parse(Console.ReadLine()!);
double X = 0;
double Y_1 = 0;
double Y_2 = 0;

X = (b2 - b1) / (k1 - k2);
Y_1 = k1 * X + b1;
Y_2 = k2 * X + b2;

Console.WriteLine("Координаты точки пересечения: (" + X + "; " + Y_1 + ")");
Console.WriteLine("Координаты точки пересечения: (" + X + "; " + Y_2 + ") (проверка)");

