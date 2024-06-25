// Задача 2: 
// Напишите программу, 
// которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, 
// в которой находится эта точка.

System.Console.WriteLine("Введите координату X: ");
int xNum = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine("Введите координату Y: ");
int yNum = Convert.ToInt32(System.Console.ReadLine());

if (xNum > 0 && yNum > 0)
{
    System.Console.WriteLine($"Точка с координатами {xNum};{yNum} находится в плоскости 1");
}
else if (xNum > 0 && yNum < 0)
{
    System.Console.WriteLine($"Точка с координатами {xNum};{yNum} находится в плоскости 4");
}
else if (xNum < 0 && yNum < 0)
{
    System.Console.WriteLine($"Точка с координатами {xNum};{yNum} находится в плоскости 3");
}
else if (xNum < 0 && yNum > 0)
{
    System.Console.WriteLine($"Точка с координатами {xNum};{yNum} находится в плоскости 2");
}
else
{
    System.Console.WriteLine($"Данная точка находится на оси координат!");
}