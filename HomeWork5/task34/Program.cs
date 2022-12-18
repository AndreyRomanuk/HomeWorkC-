// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using Common;

int[] array = CreatRandomArray.CreatNewRandomArray(8, 100, 1000);

PrintArray(array);

int result = EvenNambers(array);

Console.WriteLine(result);




int EvenNambers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count += 1;
        }
    }
    return count;
}

void PrintArray(int[] array)
{
    string str = string.Join(", ", array);
    Console.WriteLine($"[ {str} ]");
}
