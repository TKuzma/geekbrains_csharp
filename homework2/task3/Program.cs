// Задача 3:
// Напишите программу, 
// которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

System.Console.WriteLine("Введите число от 10 до 99: ");
int number = Convert.ToInt32(Console.ReadLine());
int secondDigit = number % 10;
int firstDigit = number / 10;


if (number >= 10 && number <= 99)
{

    if (firstDigit > secondDigit)
        System.Console.WriteLine($"Первая цифра {firstDigit} > второй цифры {secondDigit}");

    else if (secondDigit > firstDigit)
        System.Console.WriteLine($"Первая цифра {firstDigit} < второй цифры {secondDigit}");
    else    
        System.Console.WriteLine("Цифры равны между собой");
}
else 
    System.Console.WriteLine("Это не двухзначное число!");