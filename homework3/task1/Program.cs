// Задача 1:
// Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,90].

// Начальные условия:

// int[] array = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива
// Выводится: 5

int count = 0;

Random rand = new Random();

// Задаем массив из 10 целых чисел
int[] array = new int[10];

// Заполнение массива
for (int i = 0; i < array.Length; i++)
    array[i] = rand.Next(1, 101);

// Вывод массива
foreach (int number in array)
    System.Console.Write(number + " ");

System.Console.WriteLine();

// Отбираем нужные числа
foreach (int number in array)
{
    if (number >= 10 && number <= 90)
    {
        count++;   
    }
}

// Вывод количества чисел, которые есть в заданном промежутке
System.Console.Write(count);
