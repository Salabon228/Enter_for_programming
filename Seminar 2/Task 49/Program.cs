double[,] GetRandomArray(int rows, int columns)
{
    Random random = new Random();
    var result = new double[rows,columns];
    for (int i = 0; i < rows; i++)
    {                                                            
        for (int j = 0; j < columns; j++)
        {
            result[i,j] = random.NextDouble();
        }   
    }
    return result;
}
int rows = 3;
int columns = 3;

void PrintArray(double[,] array)
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