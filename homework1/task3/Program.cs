// Напишите программу, 
// которая на вход принимает число number и выводит, 
// является ли число чётным (делится ли оно на два без остатка).

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    System.Console.WriteLine($"Число {number} является четным");
}
else
{
    System.Console.WriteLine($"Число {number} является нечетным");
}

