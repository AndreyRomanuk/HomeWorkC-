﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");

int number = int.Parse(Console.ReadLine());

if (number < 100 || number > 999)
{        
    Console.WriteLine($"{number} не трехзначное число");
}

else
{
    number = number / 10 % 10;
    Console.WriteLine(number);
}