// Задание 3.
// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

void Main()
{
    string? str = Console.ReadLine();
    str = str!.ToLower();
    System.Console.Write(CountVowels(str!));
}

int CountVowels(string? str)
{
    int count = 0;

    foreach(char c in str!)
        if (IsVowel(c))
            count++;
    
    return count;
}

bool IsVowel(char c)
{
    return "aeouyi".Contains(c);
}

Main();