// Задание 1. Совместная работа
// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом
// массиве.
// Примеры
// [1 3 4 19 3] => 2
// [4 3 4 1 9 5 21 13] => 3

void Main()
{
    int arraySize = ReadInt("Введите размер массива: ");
    int[] array = GenerateArray(arraySize, 0, 20);
    PrintArray(array);
    System.Console.WriteLine();
    System.Console.WriteLine(CountPrimary(array));
}

// Подсчет кол-ва простых чисел
int CountPrimary(int[] array)
{
    int count = 0;

    foreach (int num in array)
        if (IsPrimary(num))
            count++;
    
    return count;
}

// Проверка простое число или нет
bool IsPrimary(int number)
{
    if (number < 2)
        return false;
    for (int i = 2; i <= Math.Sqrt(number); i++)
        if (number % i == 0)
            return false;
    return true;
}

// Вывод массива
void PrintArray(int[] arrayForPrint)
{
    System.Console.Write(string.Join(", ", arrayForPrint));  // ХОРОШИЙ ВЫВОД МАССИВА
}
    
// Генерация массива
int[] GenerateArray(int size, int minValue, int maxValue)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < tempArray.Length; i++)
        tempArray[i] = rand.Next(minValue, maxValue + 1);

    return tempArray;
}

// Берем данные от пользователя (размер массива)
int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();