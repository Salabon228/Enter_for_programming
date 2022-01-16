﻿int[,] GetRandomArray(int rows, int columns)
{
    Random random = new Random();
    var result = new int[rows,columns];
    for (int i = 0; i < rows; i++)
    {                                                            
        for (int j = 0; j < columns; j++)
        {
            result[i,j] = random.Next(1,11);
        }   
    }
    return result;
}
int rows = 3;
int columns = 3;

void PrintArray(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            System.Console.Write($"{array[i,j]}\t");
        }
        System.Console.WriteLine();
    }
}
PrintArray(GetRandomArray(3,3));
