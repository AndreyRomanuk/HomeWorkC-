// Урок 1. Знакомство с языком программирования С#
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Введите первое число");

// int number1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите второе число");

// int number2 = int.Parse(Console.ReadLine());

// if (number1 > number2)
// {
//     Console.Write("max = ");
//     Console.WriteLine(number1);
// }
// else
// {
//     Console.Write("max = ");
//     Console.WriteLine(number2);
// }



// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Введите первое число");

// int number1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите второе число");

// int number2 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите третье число");

// int number3 = int.Parse(Console.ReadLine());

// int maxNumber = number1;

// if (maxNumber < number2)
// {
//     maxNumber = number2;
// }
// if (maxNumber < number3)
// {
//     maxNumber = number3;
// }

// Console.Write("max = ");
// Console.WriteLine(maxNumber);



// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Введите число");

// int number = int.Parse(Console.ReadLine());

// int result = number % 2;

// if (result == 0)
// {
//     Console.WriteLine("Число является четным!");
// }
// else
// {
//     Console.WriteLine("Число является нечетным!");
// }


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.WriteLine("Введите число");

// int number = int.Parse(Console.ReadLine());

// int i = 2;
// int result = i % 2;
// if (i > number)
// {
//     Console.WriteLine("Введите другое число!");
// }
// else
// {
//     while (i <= number)
//     {
//         if (result == 0)
//         {
//             Console.Write(i);
//             Console.Write(", ");
//             i++;
//         }
//         i++;
//     }
// }