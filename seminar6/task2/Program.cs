// Задание 2.
// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ] 

void Main()
{
    string? str = Console.ReadLine();

    // Первый способ
    char[] chars = str!.ToCharArray();
    PrintCharArray(chars);
    System.Console.WriteLine();

    // Второй способ
    char[] chars2 = StringToCharArray(str);
    PrintCharArray(chars2);
}

char [] StringToCharArray(string? str)
{
    char[] chars = new char[str!.Length];

    for (int i = 0; i < str.Length; i++)
        chars[i] = str[i];
    return chars;
}

void PrintCharArray(char[] chars)
{
    System.Console.Write(string.Join(", ", chars));
}

Main();