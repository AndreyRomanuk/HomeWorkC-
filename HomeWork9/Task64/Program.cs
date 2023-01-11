// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using Common;

int number  = InputData.IntData("Введите число:");
DecreaseNumbers(number);

void DecreaseNumbers(int number, int tmp = 1)
{
    Console.Write($"{number}, ");
    number--;
    if(tmp > number)
    {
        return;
    }
    DecreaseNumbers(number, tmp);
}