// Напишите программу, 
// которая на вход принимает число (number), 
// а на выходе выводит все чётные числа от 1 до number (включительно), 
// после каждого числа должен быть знак пробела.

System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());


// int i = 1;                         // пример решения с циклом while

// while (i <= number)
// {
//     if (i % 2 == 0)
//     {
//         System.Console.Write(i + " ");
//     }
//     i++;
// }



for (int i = 1; i <= number; i++)       // пример решения с циклом for
{
    if (i % 2 == 0)
    {
        System.Console.Write(i + " ");
    }
}