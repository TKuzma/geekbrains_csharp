// Задание 3. Совместная работа
// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231

void Main()
{
    int arraySize = ReadInt("Введите размер массива: ");
    // Создали ограничения на ввод данных от 1 до 8
    if (arraySize > 8 || arraySize < 1)
    {
        System.Console.Write("Некорректный размер массива!");
        return;
    }
    int[] array = GenerateArray(arraySize, 1, 9);
    PrintArray(array);
    System.Console.WriteLine();

    // Для вывода через Concat
    int result = Convert.ToInt32(string.Concat(array));
    System.Console.WriteLine(result);

    // Для вывода через конвертация метода Join в int:
    // int result = Convert.ToInt32(string.Join("", array));
    // System.Console.WriteLine(result);
    
    // Для вывода через математический способ:
    // System.Console.WriteLine (ArrayToInt(array));
}

// Формируем целое число из массива (Математический способ)
// int ArrayToInt(int[] array)
// {
//     int number = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         number *= 10;
//         number += array[i];
//     }
//     return number;
// }

// Вывод массива
void PrintArray(int[] arrayForPrint)
{
    System.Console.Write("[" + string.Join(", ", arrayForPrint) + "]");  // ХОРОШИЙ ВЫВОД МАССИВА
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