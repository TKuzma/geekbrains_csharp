// Задание 1.
// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива.
// Указание
// Конструктор строки вида string(char []) не использовать.
// Пример
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”


void Main()
{
    char[] chars = {'a', 'b', 'c', 'd'};
    // Первый способ
    string str = new string(chars);
    System.Console.Write(str);
    System.Console.WriteLine();
    // Второй способ
    System.Console.Write(CharsToString(chars));
    System.Console.WriteLine();
    // Третий способ
    System.Console.Write(string.Join("", chars));
    System.Console.WriteLine();
    // Четвертый способ
    System.Console.WriteLine(string.Concat(chars));

}

string CharsToString(char[] chars)
{
    string str = "";

    foreach(char c in chars)
        str += c;
    return str;
}

Main();