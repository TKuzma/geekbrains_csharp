// Напишите программу, которая принимает на вход
// трёхзначное число и возводит вторую цифру этого
// числа в степень, равную третьей цифре.


System.Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int secondDigit = number / 10 % 10;   // Узнали вторую цифру
    int result = 1;
    for (int power = number % 10; power > 0; power--)
    {
        result *= secondDigit;
    }
    System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine("Вы ввели некорректное число!");
}