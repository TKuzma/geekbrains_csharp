// Задание 2. 
// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Пример
// 2 3 4 3
//  4 3 4 1 => 2 + 3 + 5 = 10
//  2 9 5 4

void Main()
{
    int rowCount = ReadInt("Введите количество строк в двумерном массиве: ");
    int colCount = ReadInt("Введите количество столбцов в двумерном массиве: ");

    int[,] matrix = GenerrateMatrix(rowCount, colCount, 0, 9);
    PrintMatrix(matrix);

    System.Console.Write(SumMainDiag(matrix));
    System.Console.WriteLine();
    System.Console.Write(SumMainDiagSecond(matrix));
}

int SumMainDiagSecond(int[,] matrix)
{
    int sum = 0;
    int countIter = Math.Min(matrix.GetLength(0),  matrix.GetLength(1));
    for (int i = 0; i < countIter; i++)
        sum +=  matrix[i, i];
    return sum;
}

int SumMainDiag(int[,] matrix)  // Первый варинат решения (не самый удобный)
{
    int sum = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
                sum += matrix[i, j];
        }
    return sum;
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

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
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

Main();