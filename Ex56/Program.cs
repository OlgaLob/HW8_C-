// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.Clear();
Random random = new Random();
int rows = random.Next(4, 8);
int columns = random.Next(4, 8);
int[,] array = new int[rows, columns];

Console.WriteLine($"Массив размера {rows} x {columns}");
FillArray(array);
PrintArray(array);

int sumMin = 0;
int indexMin = 0;
for (int j = 0; j < columns; j++)
{
    sumMin += array[0, j];
}
for (int i = 0; i < rows; i++)
{
    int sum = 0;
    for (int j = 0; j < columns; j++)
    {
        sum += array[i, j];
    }
    Console.WriteLine($"Сумма {i + 1} строки равна {sum}");
    if (sum < sumMin)
    {
        sumMin = sum;
        indexMin = i;
    }
}
Console.WriteLine();
Console.WriteLine($"Наименьшая сумма элементов находится в строке {indexMin + 1} и равна {sumMin}");

void FillArray(int[,] numbers)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(0, 15);
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

