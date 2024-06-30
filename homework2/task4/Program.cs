// Задача 4: Напишите программу, 
// которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.

System.Console.WriteLine("Введите натуральное число N: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 0)
{
    if (number < 10)
    {
        Console.WriteLine(number);
    }
    else
    {
        while (number > 0)
        {
            int digit = number % 10;
            number /= 10;
            if (number > 0)
            {
                Console.Write(digit + ",");
            }
            else
            {
                Console.WriteLine(digit);
            }
        }
    }   
}    
else 
{
    System.Console.WriteLine("Ошибка! Введите натуралльное число");
}