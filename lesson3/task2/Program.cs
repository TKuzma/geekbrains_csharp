﻿// Задача 2
// Вывод на экран квадратов чисел от 1 до N

void PrintSquares(int limit)
{
    int i = 0;
    while (i <= limit)
    {
        System.Console.Write($"{i*i} ");
        i++;
    }
}
PrintSquares(5);
PrintSquares(10);
PrintSquares(15);