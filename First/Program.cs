int[,] FillAndPrintMatrix(int countString, int countColumn)
{
    int[,] array = new int[countString,countColumn];
    for (int i = 0; i < countString; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
    return array;
}


void SortElementsInString(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1 - j; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int help = array[i,k];
                    array[i,k] = array[i,k + 1];
                    array[i,k + 1] = help;
                }
            }
        }
    }
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию");
Console.WriteLine("элементы каждой строки двумерного массива.");
int sizeString = new Random().Next(1, 6);
int sizeColumn = new Random().Next(1, 6);
Console.WriteLine($"m = {sizeString}, n = {sizeColumn}");
Console.WriteLine();
int[,] firstArray = FillAndPrintMatrix(sizeString, sizeColumn);
Console.WriteLine();
SortElementsInString(firstArray);
PrintMatrix(firstArray);