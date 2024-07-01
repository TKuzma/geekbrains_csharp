// Задание 1. Совместная работа
// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да 

// Вывод массива с размером, который задает сам пользователь
Console.Write("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());

int[] array = new int[arraySize];
Random rand = new Random();

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = rand.Next(10, 100);        // Диапазон возможных чисел от 10 до 99 включительно
//     System.Console.Write(array[i] + " ");
// }

// Console.Write("Введите размер массива: ");
// int arraySize = Convert.ToInt32(Console.ReadLine());


// Разные задачи лучше выделять в разные циклы!!!!!!!!!!
// Генерация массива 
for (int i = 0; i < array.Length; i++)
    array[i] = rand.Next(10, 100);        // Диапазон возможных чисел от 10 до 99 включительно
// Вывод массива
for (int i = 0; i < array.Length; i++)
    System.Console.Write(array[i] + " ");

Console.Write("\nВведите искомый элемент: ");
int findNumber = Convert.ToInt32(Console.ReadLine());
bool numberIsFinded = false;

for (int i = 0; i < array.Length; i++)
    if (array[i] == findNumber)
    {
        numberIsFinded = true;
        break;
    }

if (numberIsFinded)
    System.Console.WriteLine("Да!");
else
    System.Console.WriteLine("Нет!");

