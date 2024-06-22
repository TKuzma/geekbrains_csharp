// Напишите программу, 
// которая на вход принимает два числа и выводит, 
// какое число большее, а какое меньшее.

// System.Console.WriteLine("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// if (firstNumber > secondNumber || firstNumber < secondNumber)
//     if (firstNumber > secondNumber)
//     {
//         System.Console.WriteLine($"Первое число больше: {firstNumber} > {secondNumber}");
//     }
//     else 
//     {
//         System.Console.WriteLine($"Второе число больше: {secondNumber} > {firstNumber}");
//     }
// else
// {
//     System.Console.WriteLine("Они равны!");
// }




// using System;

// public class Answer
// {
//     static void CompareNumbers(int firstNumber, int secondNumber)
//     {
//         if (firstNumber > secondNumber || firstNumber < secondNumber)
//             if (firstNumber > secondNumber)
//             {
//                 System.Console.WriteLine($"Первое число больше: {firstNumber} > {secondNumber}");
//             }
//             else
//             {
//                 System.Console.WriteLine($"Второе число больше: {secondNumber} > {firstNumber}");
//             }
//         else
//         {
//             System.Console.WriteLine("Они равны!");
//         }
//     }


//     // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args)
//     {
//         int firstNumber, secondNumber;

//         if (args.Length >= 2)
//         {
//             firstNumber = int.Parse(args[0]);
//             secondNumber = int.Parse(args[1]);
//         }
//         else
//         {
//             // Здесь вы можете поменять значения для отправки кода на Выполнение
//             firstNumber = 6;
//             secondNumber = 27;
//         }

//         // Не удаляйте строки ниже
//         CompareNumbers(firstNumber, secondNumber);
//     }
// }