// Напишите программу, 
// которая на вход принимает два числа и выводит, 
// какое число большее, а какое меньшее.

System.Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber || firstNumber < secondNumber)
    if (firstNumber > secondNumber)
    {
        System.Console.WriteLine($"Первое число больше: {firstNumber} > {secondNumber}");
    }
    else 
    {
        System.Console.WriteLine($"Второе число больше: {secondNumber} > {firstNumber}");
    }
else
{
    System.Console.WriteLine("Они равны!");
}