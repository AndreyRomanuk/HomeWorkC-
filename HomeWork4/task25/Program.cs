// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. Не использовать метод Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
using Common;

Console.WriteLine("Введите число A");

int a = GetNumber.GetNumberFromUser();

Console.WriteLine("Введите число B");

int b = GetNumber.GetNumberFromUser();

int mathPow = MathPow(a, b);

Console.WriteLine($"Число {a} в степени {b} - {mathPow}");



int MathPow(int numberA, int numberB)
{
    int count = numberA;
    for (int i = 1; i < numberB; i++)
    {
        count *= numberA;
    }
    return count;
}
