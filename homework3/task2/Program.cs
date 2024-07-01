// Задача 2: 
// Задайте массив на 10 целых чисел.
// Напишите программу, которая определяет
// количество чётных чисел в массиве.

// Массив на 10 ячеек
int[] array = new int[10];

// Объявление класса
Random rand = new Random();

// Объявление переменной-счетчика 
int count = 0;

// Создание массива с 10-ю случайными числами от 1 до 100
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(1, 101);
}                      

// Вывод массива в терминал
for (int i = 0; i < array.Length; i++)
    System.Console.Write(array[i] + " ");

// Отступ в терминале для красоты
System.Console.WriteLine();

// Проверка числа на четность, если условие выполняется то прибавляем 1 в переменную count
foreach (int number in array)
{
    if (number % 2 == 0)
    {
        count++;
    } 
}

// Вывод количества искомых чисел
System.Console.Write(count);