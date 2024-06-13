int n = 10;
int[] array = new int[n];
int i = 0;

while (i < array.Length)           // while (i < n)
{
    array[i] = i + 1;
    //Console.Write(array[i]);
    //Console.Write(' ');
    Console.Write($"{array[i]} ");
    i = i + 1;
}
