// Напишите программу, которая заполнит спирально массив 4 на 4.
void Zadacha62()
{
    Console.Clear();
    int rows = 4;
    int columns = 4;
    int[,] numbers = new int[rows, columns];
    int index = 0;
    int currentRow = 0;
    int currentColumn = 0;
    int changeIndexRow = 0;
    int changeIndexColumn = 1;
    int steps = columns;
    int tern = 0;
    while (index < numbers.Length)
    {
        numbers[currentRow, currentColumn] = index + 1;
        index++;
        steps--;
        if (steps == 0)
        {
            steps = columns - 1 - tern / 2;
            int temp = changeIndexRow;
            changeIndexRow = changeIndexColumn;
            changeIndexColumn = -temp;
            tern++;
        }
        currentRow += changeIndexRow;
        currentColumn += changeIndexColumn;
    }
    PrintArray(numbers);
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

Zadacha62();