// Напишите программу, 
// которая принимает на вход три числа и 
// выдаёт максимальное из этих чисел.

// System.Console.WriteLine("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите третье число: ");
// int thirdNumber = Convert.ToInt32(Console.ReadLine());

// if (firstNumber > secondNumber && firstNumber > thirdNumber)
// {
//     System.Console.Write($"Наибольшее число - первое: {firstNumber}");
// }
// else if (secondNumber > firstNumber && secondNumber > thirdNumber)
// {
//     System.Console.Write($"Наибольшее число - второе: {secondNumber}");
// }
// else
// {
//     System.Console.Write($"Наибольшее число - третье: {thirdNumber}");
// }


// using System;

// public class Answer
// {

//     static int FindMax(int a, int b, int c)
//     {
//         if (a > b && a > c)
//         {
//             return(a);
//         }
//         else if (b > a && b > c)
//         {
//             return(b);
//         }
//         else
//         {
//             return(c);
//         }
//     }

//     // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args)
//     {
//         int a, b, c;

//         if (args.Length >= 3)
//         {
//             a = int.Parse(args[0]);
//             b = int.Parse(args[1]);
//             c = int.Parse(args[2]);
//         }
//         else
//         {
//             // Здесь вы можете поменять значения для отправки кода на Выполнение
//             a = 5;
//             b = 6;
//             c = 7;
//         }

//         // Не удаляйте строки ниже
//         int result = FindMax(a, b, c);
//         System.Console.WriteLine($"{result}");
//     }
// }



// Еще один метод решения

// using System;

// public class Answer {
//     static int FindMax(int a, int b, int c)
//     {
//       int max = a;
//         if (max < b)
//         {
//             max = b;
//         }
//         if (max < c)
//         {
//             max = c;
//         }
//         return max;
//     }

//     static public void Main(string[] args) {
//         int a, b, c;

//         if (args.Length >= 3) {
//             a = int.Parse(args[0]);
//             b = int.Parse(args[1]);
//             c = int.Parse(args[2]);
//         } else {
//             a = 5;
//             b = 6;
//             c = 7;
//         }

//         int result = FindMax(a, b, c);
//         System.Console.WriteLine($"{result}");
//     }
// }