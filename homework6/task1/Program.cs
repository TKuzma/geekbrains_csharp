// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

// Первый вариант
// void Main()
// {
//     int numRow = ReadInt("Введите колтчество строк: ");
//     int colRow = ReadInt("Введите количество столбцов: ");

//     char[,] matrix = GenerateCharMatrix(numRow, colRow);
//     PrintMatrix(matrix);
//     System.Console.WriteLine();

//     char[] array = MatrixToArray(matrix);
//     PrintArray(array);
//     System.Console.WriteLine();    

//     string str = new string(array);
//     System.Console.Write(str);
// }

// void PrintArray(char[] array)
// {
//     System.Console.Write(string.Join(", ", array));
// }

// char[] MatrixToArray(char[,] matrix)
// {
//     int rows = matrix.GetLength(0);
//     int cols = matrix.GetLength(1);
//     char[] charArr = new char[rows * cols];
    
//     int index = 0;
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             charArr[index] = matrix[i, j];
//             index++;
//         }
//     }
//     return charArr;
// }

// void PrintMatrix(char[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// int ReadInt(string msg)
// {
//     System.Console.Write(msg);
//     return Convert.ToInt32(Console.ReadLine());
// }

// char[,] GenerateCharMatrix(int numRow, int colRow)
// {
//     char[,] tempMatrix = new char[numRow, colRow];
//     Random rand = new Random();

//     for (int i = 0; i < numRow; i++)
//     {
//         for (int j = 0; j < colRow; j++)
//         {
//             tempMatrix[i, j] = (char)rand.Next('A', 'Z');
//         }
//     }
//     return tempMatrix;
// }

// Main();


// Второй вариант
void Main()
{
    int rows = ReadInt("Введите количество строк: ");
    int cols = ReadInt("Введите количество столбцов: ");

    char[,] matrix = GenerateMatrix(rows,cols); 
    PrintMatrix(matrix);
    System.Console.WriteLine();

    System.Console.Write(FromMatrixToString(matrix));
}

string FromMatrixToString(char[,] matrix)
{
    string str = "";

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            str += matrix[i, j];
        }
    }
    return str;
}

void PrintMatrix(char[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

char[,] GenerateMatrix(int rows, int cols)
{
    char[,] tempMatrix = new char[rows, cols];   
    Random rand = new Random();

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = (char)rand.Next('A', 'Z');
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