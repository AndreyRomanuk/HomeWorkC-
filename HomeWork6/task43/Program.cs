// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using Common;

Console.WriteLine("Введите координаты прямых");

double k1 = GetNumber.GetNumberFromUser();
double b1 = GetNumber.GetNumberFromUser();
double k2 = GetNumber.GetNumberFromUser();
double b2 = GetNumber.GetNumberFromUser();

double x = (-1 * (b1 - b2)) / (k1 - k2);
double y1 = k1 * x + b1;
double y2 = k2 * x + b2;
//Console.WriteLine(x);
Console.WriteLine($"{y1}, {y2}");

//Не понимаю, почему не работает следующий код?

// double result = IntersectionPoint(k1, b1, k2, b2);

// Console.WriteLine(result);

// double IntersectionPoint(double k1, double b1, double k2, double b2)
// {
//     double x = (b1 - b2) / (k1 - k2);
//     double y1 = k1 * x + b1;
//     double y2 = k2 * x + b2;
//     return (y1, y2);
// }
