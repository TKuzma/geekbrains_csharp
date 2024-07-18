// Задание 1.
// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.
// Пример
// 2 3 4 3
//  2 9 5 4
//  4 3 4 1 
// =>
// 4 3 4 3
// 4 3 4 1
// 2 9 25 

void Main()
{
    int rowCount = ReadInt("Введите количество строк в двумерном массиве: ");
    int colCount = ReadInt("Введите количество столбцов в двумерном массиве: ");

    int[,] matrix = GenerrateMatrix(rowCount, colCount, 0, 99);
    PrintMatrix(matrix);

    // ChangeMatrix(matrix);
    // PrintMatrix(matrix);

    ChangeMatrixSecond(matrix);
    PrintMatrix(matrix);
}

void ChangeMatrixSecond(int[,] matrix)  // Второй вариант решения
{
    for (int i = 0; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j += 2)
        {
            matrix[i, j] *= matrix[i, j];
        }
    }
}

void ChangeMatrix(int[,] matrix)    // Первый вариант решения
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
                matrix[i, j] *= matrix[i, j];
        }
    }
}

void PrintMatrix(int[,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixForPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[,] GenerrateMatrix(int rows, int cols, int minValue, int maxValue)
{
    int[,] tempMatrix = new int[rows, cols];
    Random rand = new Random();

    int numRow = tempMatrix.GetLength(0);
    int colRow = tempMatrix.GetLength(1);
    for (int i = 0; i < numRow; i++)
    {
        for (int j = 0; j < colRow; j++)
        {
            tempMatrix[i, j] = rand.Next(minValue, maxValue + 1);
        }
    }
    return tempMatrix;
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();