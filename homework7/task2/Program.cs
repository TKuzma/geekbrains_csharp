// Задача 2: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

void Main()
{
    int m = -1;
    int n = -1;
    while (m < 0 || n < 0)
    {
        m = ReadInt("Введите первое неотрицательное число: ");
        n = ReadInt("Введите второе неотрицательное чсило: ");

        if (m < 0 || n < 0)
        {
            System.Console.Write("Допущена ошибка!");
        }
    }
    System.Console.WriteLine(AckermannFunction(m, n));
}

int AckermannFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return AckermannFunction(m - 1, 1);
    else
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();