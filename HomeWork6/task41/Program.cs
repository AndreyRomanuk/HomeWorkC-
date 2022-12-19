// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int[] array = CreatNewRandomArray(5);

PrintArray(array);

int result = PositiveNumbers(array);

Console.WriteLine(result);

int PositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count += 1;
        }
    }
    return count;
}

int[] CreatNewRandomArray(int size)
{
    int[] array = new int[size];

    for (var i = 0; i < size; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    string str = string.Join(", ", array);
    Console.WriteLine($"[ {str} ]");
}
