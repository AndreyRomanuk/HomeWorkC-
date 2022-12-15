// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

using Common;

Console.WriteLine("Введите число");
int number = GetNumber.GetNumberFromUser();
int sumOfNumbers = SumNumbersFromNum(number);
Console.WriteLine($"Сумма чисел в числе {number} равна {sumOfNumbers}");



int SumNumbersFromNum(int num)
{
    int sumNum = 0;
    int count;
    while (num > 0)
    {
        count = num % 10;
        sumNum += count;
        num /= 10;
    }
    return sumNum;
}