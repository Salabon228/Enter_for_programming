// Сформировать случайным образом N-элементный массив, 
// заполненный однозначными целыми числами разных знаков. 
// Задать k и выяснить

// сколько раз повторяется k в массиве
// сколько элементов находится между первым и последним k
// сколько раз встречается k

// void FillArray(int[] collection) // это функция для внесения случайных 
//                                 //чисел в массив

// {
//     int lenght = collection.Length;
//     int index = 0;
//     while (index < lenght)
//     {
//         collection[index] = new Random().Next(1,10);
//         index++;
//     }
// }

// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.WriteLine(col[position]);
//         position++;
//     }
// }

// int[] array = new int[15]; // создай новый массив с 10 элементами


// FillArray(array);
// PrintArray(array);
// int lenght = array.Length;
// int k = 5;
// int count = 0;
// int N = count; // N -сколько элементов между первым и последним k
// int index = 0;
// int FirstIndex = 0;
// int SecondIndex = 0;
// int maxCount = count;

// while(index < lenght)
// {
//     if (array[index] == k) 
//     {
//         count++;   
//     }  
//     else
//     {

//     }
    
//     if (count == 1) 
//     {
//         FirstIndex = index;
//     }
//     if ((count > 1) & (count > maxCount)) 
//     {
//         maxCount = count;
//         SecondIndex = index;
//     }

//     index++;
//     N = SecondIndex - (FirstIndex+1);
    

// }
// Console.WriteLine();
// Console.WriteLine($"число {k} встречается {count} раз ");
// Console.WriteLine($"между первым и последним k {N} элементов ");


