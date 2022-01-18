int rows = 5;
int columns = 5;

int[,] GetRandomArray(int rows, int columns)
{
    Random random = new Random();
    var result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = random.Next(1, 11);
        }
    }
    return result;
}
int[,] ChangeArray(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if ((i % 2 == 0) && (j % 2 ==0))
            {
                array[i,j] *= array[i,j];
            }
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

PrintArray(ChangeArray(GetRandomArray(rows, columns)));