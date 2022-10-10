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

void SumElementsOfString (int[,] array)
{
    int sumOfFirstString = 0;
    for (int k = 0; k < array.GetLength(1); k++)
    {
        sumOfFirstString += array[0,k];
    }
    int minSum = sumOfFirstString;
    int positionOfMin = 0;
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sumElement = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumElement += array[i,j];
        }

        if (sumElement < minSum)
        {
            minSum = sumElement;
            positionOfMin = i;
        }

    }
    Console.WriteLine($"Строка с наименьшей суммой элементов {positionOfMin + 1}");
}


Console.WriteLine("Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, ");
Console.WriteLine("которая будет находить строку с наименьшей суммой элементов");

Console.Write("Введите количество строк массива: ");
int sizeString = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int sizeColumn = Convert.ToInt32(Console.ReadLine());
//int sizeString = 4;
//int sizeColumn = 7;
Console.WriteLine($"m = {sizeString}, n = {sizeColumn}");
Console.WriteLine();
int[,] firstArray = FillAndPrintMatrix(sizeString, sizeColumn);
Console.WriteLine();
SumElementsOfString(firstArray);

