// Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или 
// же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

(bool, int, int) FindNum(int[,] array, int num)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j=0; j< array.GetLength(1); j++)
        {
            if (array [i,j] == num)
                return (true, i, j);
        }
    }
    return (false, -1, -1);
}





int [,] array = new int [8,9];
Console.WriteLine("введите искомое число");
int num = Convert.ToInt32(Console.ReadLine());
CreateArray(array);
PrintArray(array);
(bool isFound, int row, int column) = FindNum(array, num);
if (isFound)
    Console.WriteLine($"индекс искомого числа: ({row}, {column})");
else
    Console.WriteLine("число не найдено");

