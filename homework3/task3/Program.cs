// Задача 3: 
// Задайте массив из вещественных чисел с
// ненулевой дробной частью. Найдите разницу между
// максимальным и минимальным элементов массива.



// Написать описание
Random rand = new Random();

double[] array = new double[10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = Math.Round(rand.Next(0, 10) + rand.NextDouble(), 2);
    System.Console.Write(array[i] + " ");
}
System.Console.WriteLine();

double maxValue = 0;
double minValue = 5.5;

for (int i = 0; i < array.Length; i++)  // Обязательно на семинар ВОПРОС ПО ДЗ
{
    if (minValue > array[i])
    {
        minValue = array[i];
    }
    else if (maxValue < array[i])
    {
        maxValue = array[i];
    }
}
System.Console.Write("Минимальное значение: " + minValue + " Максимальное значение: " + maxValue);
System.Console.WriteLine("\nРазница: " + (maxValue - minValue));


