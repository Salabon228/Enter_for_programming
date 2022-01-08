// int[,] GetRandomArray(int rows, int columns)
// {
//     Random random = new Random();
//     var result = new int[rows,columns];
//     for (int i = 0; i < rows; i++)
//     {                                                            
//         for (int j = 0; j < columns; j++)
//         {
//             result[i,j] = random.Next(100);
//         }   
//     }
//     return result;
// }
// void Main()
// {
//     int rows = 10;
//     int columns = 5;
//     var myArray = GetRandomArray(rows, columns);
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)                            >>> Заполнение матрицы <<<
//         {
//             System.Console.Write($"{myArray[i,j]}\t");
//         }
//         System.Console.WriteLine(); 
//     }
// }
// Main();
// =====================================================================================================================================================================

// Console.Write("Введите высоту треугольника: ");
// string? msg = Console.ReadLine();
// int height = Convert.ToInt32(msg);
// for (int i = 0; i < height; i++)
// {
//     for (int j = height; j > i; j--)                                 >>> Рисует треугольник из символов <<<
//     {                                                
//         System.Console.Write(" ");
//     }
//     for (int j = 0; j <= i; j++)
//     {
//         System.Console.Write("*");
//     }
//     System.Console.WriteLine();
// }
// =====================================================================================================================================================================

// int [] myArray = new int [5] {1,4,2,6,3};
// System.Console.WriteLine(myArray[3]);
// или
// int [] myArray = new int [] {1,4,2,6,3};
// System.Console.WriteLine(myArray[3]);                            >>> выделение памяти под массив и заполнение массива <<<
// или
// int [] myArray = {1,4,2,6,3};
// System.Console.WriteLine(myArray[3]);
// int [] myArray = Enumerable.Repeat(5,10).ToArray();              >>> заполняет массив из 10 элементов цифрами 5 <<<
// int [] myArray = Enumerable.Range(4,5).ToArray();                >>> заполняет массив из 5 элементов цифрами от 4 далее <<<


// =====================================================================================================================================================================

// System.Console.Write("Введите количество элементов массива:\t");

// int elementScout = int.Parse(Console.ReadLine());                          

// int [] myArray = new int[elementScout];

// for (int i = 0; i < myArray.Length ; i++)
// {
//     System.Console.Write($"\nВведите элемент массива под индексом {i}:\t ");               \n позволяет перейти на следующую строку, т.е. эту запись делает строкой ниже
//     myArray[i] = int.Parse(Console.ReadLine());
// }

// System.Console.WriteLine("\nВывод массива:");

// for (int i = 0; i < myArray.Length; i++)
// {
//     System.Console.WriteLine(myArray[i]);
   
// }