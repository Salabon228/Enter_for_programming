int[,] GetRandomArray(int rows, int columns)
{
    Random random = new Random();
    var result = new int[rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i,j] = random.Next(100);
        }   
    }
    return result;
}
void Main()
{
    int rows = 10;
    int columns = 5;
    var myArray = GetRandomArray(rows, columns);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            System.Console.Write($"{myArray[i,j]}\t");
        }
        System.Console.WriteLine(); 
    }
}
Main();