// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
void Zadacha58()
{
    Console.Clear();
    Random random = new Random();
    int rowsFirst = random.Next(4,8);
    int columnsFirst = random.Next(4,8);
    int rowsSecond = columnsFirst;
    int columnsSecond = random.Next(4,8);
    int[,] firstMatrix = new int[rowsFirst, columnsFirst];
    int[,] secondMatrix = new int[rowsSecond, columnsSecond];
    FillArray(firstMatrix);
    PrintArray(firstMatrix);
    Console.WriteLine();
    FillArray(secondMatrix);
    PrintArray(secondMatrix);

    int[,] result = new int[rowsFirst, columnsSecond];
    for (int i = 0; i < rowsFirst; i++)
    {
        for (int j = 0; j < columnsSecond; j++)
        {
            for (int k = 0; k < rowsSecond; k++)
            {
                result[i,j] += firstMatrix[i,k]*secondMatrix[k,j];
            }
        }
    }
    Console.WriteLine();
    PrintArray(result);
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
            numbers[i, j] = random.Next(0, 7);
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
Zadacha58();