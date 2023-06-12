// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void CreateArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            double num = new Random().NextDouble();
            array[i, j] = new Random().Next(-30, 31)+num;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write($"{Math.Round(array[i, j],3),7}  ");
        System.Console.WriteLine();
    }
}



Console.WriteLine("введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
double [,] array = new double [rows,cols];
CreateArray(array);
PrintArray(array);