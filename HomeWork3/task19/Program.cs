// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

using Common;

Console.WriteLine("Введите число");

int number = int.Parse(Console.ReadLine());

int revNum = ReversNumber.GetNumberOfRevers(number);

Console.WriteLine(revNum);

if (revNum == number)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}