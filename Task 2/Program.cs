// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.


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
void OrderDecreas(int[,] array)
{
     for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
           for (int k = 0; k < array.GetLength(1) - n - 1; k++)
            {
                if (array[m, k] < array[m, k + 1])
                {
                    int temp = array[m, k];
                    array[m, k] = array[m, k + 1];
                    array[m, k + 1] = temp;
                }
            }
        Console.WriteLine();
    }
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
OrderDecreas(array);
PrintArray(array);