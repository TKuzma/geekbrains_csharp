// Задание 3.
// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)

Random rand = new Random();

int[] array = new int[rand.Next(5, 16)];    // задали массив от 5 до 15 элементов


// Генерация массива 
for (int i = 0; i < array.Length; i++)
    array[i] = rand.Next(-10, 11); 

// Вывод массива через foreach
foreach (int number in array)
    System.Console.Write(number + " ");

System.Console.WriteLine();  // Отступ для красоты вывода

// Создание нового массива
int[] multPairs = new int[array.Length / 2];

// Цикл, который умножает числа, как указано в условии
for (int i = 0; i < array.Length / 2; i++)
    multPairs[i] = array[i] * (array[array.Length - 1 - i]);

// Вывод массива через foreach
foreach (int number in multPairs)
    System.Console.Write(number + " ");

