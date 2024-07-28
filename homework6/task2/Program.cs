// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

void Main()
{
    System.Console.Write("Введите текст: ");
    string? str = Console.ReadLine();
    System.Console.Write(str!.ToLower());
}

Main();