// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-30, 31);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write($"{array[i, j],3}  ");
        System.Console.WriteLine();
    }
}

void FindSum(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        double result =0;
        //double [] newarray;
        for (int j = 0; j < array.GetLength(0); j++)
            sum += array[j,i];
        result = sum / array.GetLength(0);
        Console.WriteLine(result);
        sum = 0;
    }

}





Console.WriteLine("введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
CreateArray(array);
PrintArray(array);
FindSum(array);

