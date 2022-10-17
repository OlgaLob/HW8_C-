//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void Zadacha54()
{
    Console.Clear();
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] array = new int[rows, columns];

    Console.WriteLine($"Массив размера {rows} x {columns}");
    FillArray(array);
    PrintArray(array);
    SortArray(array);
    Console.WriteLine();
    Console.WriteLine("Массив с отсортированными по убыванию строками:");
    PrintArray(array);
}

void SortArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            int border = columns - j - 1;
            for (int k = 0; k < border; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    (array[i, k], array[i, k + 1]) = (array[i, k + 1], array[i, k]);
                }
            }
        }
    }
}

void FillArray(int[,] numbers)
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

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");

        }
        Console.WriteLine();
    }
}

Zadacha54();

