// Задача 4**(не обязательно): 
// Дано натуральное
// число в диапазоне от 1 до 100 000. Создайте массив,
// состоящий из цифр этого числа. Старший разряд
// числа должен располагаться на 0-м индексе
// массива, младший – на последнем. Размер массива
// должен быть равен количеству цифр.


// Попробуй перевернуть массив мы такое делали, а вот как записать все эти числа в массив сам думай, но, наверное с циклом

// Ввод данных
System.Console.WriteLine("Введите натуральное число от 1 до 100 000: ");
int number = Convert.ToInt32(Console.ReadLine());

// Создание временного массива    
int[] array = new int[6];
int count = 0;

// Проверка правильности вводимых данных
if (number >= 1 && number <= 100000)
{


    // Извлеченеие цифр и запись их в массив
    while (number > 0)
    {
        array[count] = number % 10;
        number /= 10;
        count++;
    }
}
// При неправильном вводе данных сообщение об ошибке
else
{
    System.Console.WriteLine("Ошибка! Введите натуралльное число от 1 до 100 000");
}

// Создание массива нужного размера
int[] result = new int[count];
Array.Copy(array, result, count);

// // Вывод данных в терминал
// for (int i = 0; i < result.Length; i++)
// {
//     if (i < result.Length - 1)
//         System.Console.Write(result[i] + ", ");
//     else 
//         System.Console.Write(result[i]);
// }

 
// Переворот массива в нужном порядке
int i = 0;
int i2 = result.Length - 1;
while (i <= result.Length / 2)
{
    int temp = result[i];
    result[i] = result[i2];
    result[i2] = temp;
    i++;
    i2 = i2 - 1;
}

// Вывод массива в терминал
System.Console.WriteLine();
for (int j = 0; j < result.Length; j++)
{
    if (j < result.Length - 1)
        System.Console.Write(result[j] + ", ");
    else
        System.Console.Write(result[j]);
}




