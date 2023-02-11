// Написать программу, которая обменивает элементы первой строки и последней строки




void FillArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            Console.Write($"{array[m, n]} ");
        }
        Console.WriteLine();
    }
}
void Change(int[,] array)
{
    int temp = 0;
    for (int m = 0; m < array.GetLength(1); m++)
    {
        temp = array[0, m];
        array[0, m] = array[array.GetLength(0) - 1, m];
        array[array.GetLength(0) - 1, m] = temp;
    }
}

Console.WriteLine("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);
Console.WriteLine();
Change(array);
PrintArray(array);
