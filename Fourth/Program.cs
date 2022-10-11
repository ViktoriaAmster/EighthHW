Console.WriteLine("Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.");
Console.WriteLine("Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");

void FillCubicMatrix (int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i,j,k] = new Random().Next(1,10);
            } 
        }
    }
}


void PrintCubicMatrix (int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i,j,k]}({i},{j},{k})   ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int widthMatrix = 4;
int heightMatrix = 4;
int depthMatrix = 4;
int [,,] cubicMatrix = new int[heightMatrix,widthMatrix,depthMatrix];
FillCubicMatrix(cubicMatrix);
PrintCubicMatrix(cubicMatrix);