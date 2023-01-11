// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using Common;

int line = InputData.IntData("Введите количество строк: ");
int column = InputData.IntData("Введите количество столбцов: ");
int[,] array = GetArray.CreateRandom2DArrayInt(line, column, -100, 100);
GetArray.Print2DArrayInt(array);
Console.WriteLine();
SortLineDecreasing(array);
GetArray.Print2DArrayInt(array);


void SortLineDecreasing(int[,] array)
{
    int tmp;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            for (int j = k + 1; j < array.GetLength(1); j++)
            {
                if (array[i, k] < array[i, j])
                {
                    tmp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = tmp;
                }
            }
        }
    }
}