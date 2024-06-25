// Напишите программу, которая выводит третью с
// конца цифру заданного числа или сообщает, что
// третьей цифры нет.
// 456 => 6
// 7812 => 8
// 91 => Третьей цифры нет

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(System.Console.ReadLine());

// if (number > 99)                                     // Ищем третью цифру от конца всего числа
// {
//     System.Console.WriteLine(number % 1000 / 100);
// }
// else
//     System.Console.WriteLine("Третьей цифры нет");

if (number > 99)                                
{
    while (number > 999)                          // Ищем третью цифру от начала
    number /= 10;
    System.Console.WriteLine(number % 10);
}
else
    System.Console.WriteLine("Третьей цифры нет");

