// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2


System.Console.WriteLine("Введите положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());


// ЦИКЛ WHILE

// int i = -number; // -1 * number

// while (i <= number)
// {
//     System.Console.Write(i + " ");
//     i++; // i = i + 1 // i += 1
// }


// УБЕРЕМ ВОЗМОЖНОСТЬ ВВОДА ОТРИЦАТЕЛЬНЫХ ЧИСЕЛ

// if (number < 0)
// {
//     System.Console.WriteLine("Вы ввели некорректное число!");
// }
// else
// {
//     while (i <= number)
//     {
//         System.Console.Write(i + " ");
//         i++; // i = i + 1 // i += 1
//     }
// }


//ЦИКЛ FOR

for (int i = -number; i < number; i++)  // убрали знако равно для правильного оформления
{
    System.Console.Write(i + ", ");  // сделали вывод через запятую
}
System.Console.Write(number); // вывели последнее число, чтобы после него не стояла запятая

// Можно убрать {} так как тут одна строчка