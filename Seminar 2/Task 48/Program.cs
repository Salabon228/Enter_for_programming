// int[,] myArray = new int[,]
// {
//     {2,45,12,51,52},
//     {6,7,8,3,1},
//     {1,5,65,78,13},
//     {6,3,151,5,65}
// };

// foreach (var item in myArray)
// {
//     System.Console.Write(item + " ");
// }
int[,] myArray = new int[10,6];
Random random = new Random();
for (int i = 0; i < myArray.GetLength(0); i++)   
{
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
                     
    }
}






for (int i = 0; i < myArray.GetLength(0); i++)   
{
    for (int j = 0; j < myArray.GetLength(1); j++)
    {

        System.Console.Write(myArray[i, j] + "\t");
    }
    System.Console.WriteLine();
}