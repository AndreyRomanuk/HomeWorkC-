// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
using Common;

int[] array = CreatRandomArray.CreatNewRandomArray(8, 0, 20);

PrintArray(array);




void PrintArray(int[] array)
{
    string str = string.Join(", ", array);
    Console.WriteLine($"[ {str} ]");
}
