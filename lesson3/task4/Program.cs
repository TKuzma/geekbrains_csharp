int n = 10;
int[] array = new int[n];
// Заполнение массива
void FillArray()
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rand.Next(10, 100); 
}
// Вывод массива
void PrintArray()
{
    for (int i = 0; i < array.Length; i++)
        System.Console.Write(array[i] + " ");
}
FillArray(array);
PrintArray(array);