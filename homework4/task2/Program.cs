// Задача 2: 
// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, 
// которая покажет количество чётных чисел в массиве.

void Main()
{
    int arraySize = ReadInt("Введите размер массива: ");
    int[] array = GenerateArray(arraySize, 100, 1000);
    PrintArray(array);
    System.Console.WriteLine();
    System.Console.Write(CountIfEven(array));
}

// Подсчет количества четных чисел
int CountIfEven(int[] array)
{
    int count = 0;

    foreach (int num in array)
        if (num % 2 == 0)
            count++;
    
    return count;
}

// Вывод массива
void PrintArray(int[] arrayForPrint)
{
    System.Console.Write(string.Join(", ", arrayForPrint));
}

// Генерация массива
int[] GenerateArray(int size, int minValue, int maxValue)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < tempArray.Length; i++)
        tempArray[i] = rand.Next(minValue, maxValue);

    return tempArray;
}

// Берем данные от пользователя (размер массива)
int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine()); 
}

Main();

