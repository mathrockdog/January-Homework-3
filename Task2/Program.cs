// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// y = 5 * x + 2
// y = 9 * x + 4

// 5 * x + 2 = 9 * x + 4
// 5 * x - 9 * x = 4 - 2
// -4 * x = 2
// x = 2 / -4
// x = -0.5
// y = 5 * -0.5 + 2
// y = -0.5

Console.Write("Введите первое число первого отрезка: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите второе число первого отрезка: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите первое число второго отрезка: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите второе число второго отрезка: ");
double k2 = Convert.ToDouble(Console.ReadLine());

// k1 * x + b1 = k2 * x + b2
double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.Write("Точка пересечения двух прямых равна (" + x + "; " + y + ")");