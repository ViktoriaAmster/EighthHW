Console.Write("Задача 58: Задайте две матрицы. Напишите программу, ");
Console.WriteLine("которая будет находить произведение двух матриц.");

void FillAndPrintMatrix (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
            Console.Write($"{array[i,j]}  ");
        }
        Console.WriteLine();
    }
}

int [,] multiplMatrix (int [,]firstArray, int [,] secondArray)
{
    int [,] result = new int[firstArray.GetLength(0),secondArray.GetLength(1)];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int sumOfMultipl = 0;
            for (int k = 0; k < firstArray.GetLength(1); k++)
            {
                sumOfMultipl += firstArray[i,k]*secondArray[k,j];
            }
            result[i,j]= sumOfMultipl;
        }
    }
    return result;
}

void PrintMultiplOfMatrix(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}  ");   
        }
        Console.WriteLine();
    }
}


int sizeString = new Random().Next(2,5);
int sizeColumn = new Random().Next(1,5);

int[,] firstMatrix = new int[sizeString,sizeColumn];
int[,] secondMatrix = new int[sizeColumn,sizeString];
FillAndPrintMatrix(firstMatrix);
Console.WriteLine("     x");
FillAndPrintMatrix(secondMatrix);
int[,] resultMatrix = multiplMatrix(firstMatrix,secondMatrix);
Console.WriteLine("     =");
PrintMultiplOfMatrix(resultMatrix);