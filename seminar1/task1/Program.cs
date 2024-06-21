// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

// int firstNumber = 9;
// int secondNumber = 4;

System.Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber == secondNumber * secondNumber)
{
    Console.WriteLine("a = " + firstNumber + ", b = " + secondNumber + " => да");
}
else
{
    Console.WriteLine($"a = {firstNumber}, b = {secondNumber} => нет");
}


// System.Console.WriteLine("Введите первое число: ");

// string strNumber = Console.ReadLine();
// int firstNumber = int.Parse(strNumber);        

// int firstNumber = int.Parse(Console.ReadLine();)  вместо int.Parse можно использовать Convert.ToInt32
// самому попробовать сделать с ридлайн

// ToInt16 - конвертация в byte
// ToInt32 - конвертация в int
// ToInt64 - конвертация в long
