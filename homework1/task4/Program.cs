// Напишите программу, 
// которая на вход принимает число (number), 
// а на выходе выводит все чётные числа от 1 до number (включительно), 
// после каждого числа должен быть знак пробела.

// System.Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());


// int i = 1;                         // пример решения с циклом while

// while (i <= number)
// {
//     if (i % 2 == 0)
//     {
//         System.Console.Write(i + " ");
//     }
//     i++;
// }



// for (int i = 1; i <= number; i++)       // пример решения с циклом for
// {
//     if (i % 2 == 0)
//     {
//         System.Console.Write(i + " ");
//     }
// }



// using System;

// public class Answer
// {
//     static void PrintEvenNumbers(int number)
//     {
//         // Введите свое решение ниже
//         for (int i = 1; i <= number; i++)       // пример решения с циклом for
//         {
//             if (i % 2 == 0)
//             {
//                 System.Console.Write(i + " ");
//             }
//         }


//     }


//     // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args)
//     {
//         int number;

//         if (args.Length >= 1)
//         {
//             number = int.Parse(args[0]);
//         }
//         else
//         {
//             // Здесь вы можете поменять значения для отправки кода на Выполнение
//             number = 9;
//         }

//         // Не удаляйте строки ниже
//         PrintEvenNumbers(number);
//     }
// }