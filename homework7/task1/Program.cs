// Задача 1: 
// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void Main()
{
    System.Console.Write("Введите начало промежутка: ");
    int numberStart = Convert.ToInt32(Console.ReadLine());

    System.Console.Write("Введите конец промежутка: ");
    int numberEnd = Convert.ToInt32(Console.ReadLine());

    PrintSection(numberStart, numberEnd);
}

void PrintSection(int M, int N)
{
    if (M > N) return;
    System.Console.Write(M + " ");
    PrintSection(M + 1, N);
}

Main();