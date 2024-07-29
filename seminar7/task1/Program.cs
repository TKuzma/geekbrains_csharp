// Задание 2.
// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// N=5 => 1 2 3 4 5

void Main()
{
    System.Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    PrintNumber(number);
}

void PrintNumber(int n)
{
    if (n < 1) return;
    PrintNumber(n - 1);
    System.Console.Write(n + " ");
}

Main();