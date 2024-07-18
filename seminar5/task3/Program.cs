// Задание 3.
// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива.
// Пример
// 2 3 4 3
// 4 3 4 1 => [3 3 5]
// 2 9 5 4

void Main()
{
    int rowCount = ReadInt("Введите количество строк в двумерном массиве: ");
    int colCount = ReadInt("Введите количество столбцов в двумерном массиве: ");

    int[,] matrix = GenerrateMatrix(rowCount, colCount, 0, 9);
    PrintMatrix(matrix);
    PrintArray(CalculateAverages(matrix));

}

void PrintArray(double[] array)
{
    System.Console.Write("[" + string.Join(", ", array) + "]");
}

double[] CalculateAverages(int[,] matrix)
{
    double[] averages = new double[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            averages[i] += matrix[i, j];
        }
        averages[i] /= matrix.GetLength(1);
    }
    return averages;
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