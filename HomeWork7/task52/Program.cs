// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

try
{
    int m = ReadInt("Введите m");
    int n = ReadInt("Введите n");
    int[,] array = Create2DArray(m,n);
    Print2DArray(array);
    Console.Write("Среднее арифметическое каждого столбца: ");
    double average = Average(array);
    
    //Console.WriteLine(average);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}



double Average(int[,] array)
{
    double sum = 0;
    double average = 0;
    for (var j = 0; j < array.GetLength(1); j++)
    {
        for (var i = 0; i < array.GetLength(0); i++)
        {  
            sum += array[i,j];
        }
        average = sum / array.GetLength(0);
        Console.Write(average + "; ");
    }
    Console.WriteLine();
    return average;
}


void Print2DArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] Create2DArray(int m, int n)
{
    int[,] array = new int[m,n];

    Random random = new Random();

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = random.Next(0,10);
        }
    }

    return array;
}

int ReadInt(string title)
{
    Console.WriteLine(title);

    bool isParsed = int.TryParse(Console.ReadLine(), out int number);

    if (isParsed)
    {
        return number;
    }
    
    throw new Exception("Введены не корректные символы");
}