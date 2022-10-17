// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит 
//строку и столбец, на пересечении которых расположен наименьший элемент массива.

    Console.Clear();
     Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = rows;
    Console.WriteLine($"Массив размера {rows} x {columns}");
    int[,] numbers = new int[rows, columns];
    FillArray(numbers, -100, 100);
    PrintArray(numbers);
    int min = 0;
    int i_min = 0;
    int j_min = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (numbers[i, j] < min)
            {
                min = numbers[i, j];
                i_min = i;
                j_min = j;
            }
        }
    }
    Console.WriteLine();
    Console.WriteLine($"N[{i_min + 1}, {j_min + 1}] = {min}");
    
    for (int i = 0; i < rows; i++)
    {
        if (i != i_min)
            for (int j = 0; j < columns; j++)
            {
                if (j != j_min)
                    Console.Write(numbers[i, j] + "\t");
            }
            Console.WriteLine();
    }


void FillArray(int[,] numbers, int min = -100, int max = 100)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(-100, 100);
        }
    }
}

void PrintArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

