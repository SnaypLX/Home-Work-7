// В прямоугольной матрице найти строку с наименьшей суммой элементов.


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
void Sum(int[,] array)
{
    int sum = 0;
    int minSum = 0;
    int minNum = 0;
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            if (m == 0)
            {
                sum = sum + array[m, n];
                minSum = minSum + array[m, n];
            }
            else sum = sum + array[m, n];
        }
    
    if (sum < minSum)
    {
        minSum = sum;
        minNum = m;
    }
    sum = 0;
    }

    Console.WriteLine($"Минимальная сумма {minSum} в строке {minNum}");
}

Console.WriteLine("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);
Console.WriteLine();
Sum(array);
PrintArray(array);

