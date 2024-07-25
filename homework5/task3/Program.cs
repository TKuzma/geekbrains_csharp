// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Начальные условия:

// // Начальные условия
// int[,] numbers = new int[,] {
//     {1, 2, 3},
//     {1, 1, 0},
//     {7, 8, 2},
//     {9, 10, 11}
// };
// Выводится: 1

void Main()
{
    int[,] numbers = new int[,] {
        {1, 2, 3},
        {1, 1, 0},
        {7, 8, 2},
        {9, 10, 11}
    };

    PrintMatrix(numbers);

    int[] array = SumEveryRow(numbers);
    PrintArray(array);
    System.Console.WriteLine();

    System.Console.Write(ShowMin(array));
}

int ShowMin(int[] array)
{
    int minIndex = 0;
    int minValue = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minValue)
        {
            minValue = array[i];
            minIndex = i;
        }    
    }
    return minIndex;
}

void PrintArray(int[] array)
{
    System.Console.Write(string.Join(", ", array));
}

int[] SumEveryRow(int[,] matrix)
{
    int[] sumRow = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRow[i] += matrix[i, j];
        }
    }
    return sumRow;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Main();