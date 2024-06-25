// Напишите программу, которая принимает на
// вход трёхзначное число и удаляет вторую
// цифру этого числа.
// Примеры
// a = 256 => 26
// a = 891 => 81


System.Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    // System.Console.Write(number / 100 + "" + number % 10);
    int result = Convert.ToInt32(number / 100 + "" + number % 10);
    // int result = number / 100 * 10 + number % 10;
    System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine("Вы ввели некорректное число!");
}


