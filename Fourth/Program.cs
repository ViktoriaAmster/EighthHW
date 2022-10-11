Console.WriteLine("Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.");
Console.WriteLine("Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");



void FillCubicMatrix (int[,,] array)
{   
    int[] arrayOfAlreadyThere = new int[100];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                int randomNumber = new Random().Next(10,100);
                while (arrayOfAlreadyThere[randomNumber] > 0)
                {
                   randomNumber = new Random().Next(10,100); 
                }
                array[i,j,k] = randomNumber;
                arrayOfAlreadyThere[randomNumber] = 1;
            } 
        }
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {

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

int widthMatrix = 3;
int heightMatrix = 3;
int depthMatrix = 3;
int [,,] cubicMatrix = new int[heightMatrix,widthMatrix,depthMatrix];
FillCubicMatrix(cubicMatrix);
PrintCubicMatrix(cubicMatrix);