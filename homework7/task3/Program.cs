// Задача 3: 
// Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

void Main()
{
    int arraySize = ReadInt("Введите размер массива: ");

    int[] array = GenerateArray(arraySize, 1, 100);
    PrintArray(array);
    System.Console.WriteLine();

    ShowReverseArray(array, arraySize - 1);
}

void ShowReverseArray(int[] array, int index)
{
    if (index < 0) return;

    System.Console.Write(array[index] + " ");
    ShowReverseArray(array, index - 1);
}

void PrintArray(int[] array)
{
    System.Console.Write(string.Join(" ", array));
}

int[] GenerateArray(int arraySize, int minValue, int maxValue)
{
    int[] tempArray = new int[arraySize];
    Random rand = new Random();

    for (int i = 0; i < arraySize; i++)
    {
        tempArray[i] = rand.Next(minValue, maxValue + 1);
    }
    return tempArray;
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();