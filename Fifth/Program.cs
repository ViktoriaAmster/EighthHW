Console.WriteLine("Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.");

int[,] FillLikeSnail(int size)
{
    int[,] result = new int[size,size];
    int currentNumber = 1;
    for (int circle = 0; circle <= size / 2; circle++)
    {
        for (int j = circle; j < size-circle; j++)
        {
            result[circle,j]= currentNumber;
            currentNumber++;
        }
        for (int i = circle+1; i < size - circle - 1; i++)
        {
            result[i,size-circle-1] = currentNumber;
            currentNumber++;
        }
        for (int j = size-circle- 1; j > circle; j--)
        {
            result[size-circle-1, j]= currentNumber;
            currentNumber++;
        }
        for (int i = size-circle-1; i > circle; i--)  
        {
            result[i,circle]= currentNumber;
            currentNumber++;
        }
    }
    return result;
}


void PrintSnailMatrix(int [,] array)
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


int sizeOfMatrix = 4;
int[,] snailMatrix = FillLikeSnail(sizeOfMatrix);
PrintSnailMatrix(snailMatrix);