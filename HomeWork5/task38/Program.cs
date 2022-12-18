// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементом массива.

// [3 7 22 2 78] -> 76

using Common;

int[] array = CreatRandomArray.CreatNewRandomArray(8, 0, 100);

PrintArray(array);

int result = DifferenceInArrayNambers(array);

Console.WriteLine(result);




int DifferenceInArrayNambers(int[] array)
{
    int maxArrayNumber = 0;
    int minArrayNumber = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= maxArrayNumber)
        {
            maxArrayNumber = array[i];
        }
        else 
        {
            if (array[i] <= minArrayNumber)
            {
                minArrayNumber = array[i];
            }
        }
    }
    return maxArrayNumber - minArrayNumber;
}

void PrintArray(int[] array)
{
    string str = string.Join(", ", array);
    Console.WriteLine($"[ {str} ]");
}
