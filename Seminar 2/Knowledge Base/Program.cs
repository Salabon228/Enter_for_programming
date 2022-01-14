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

// =====================================================================================================================================================================
// using System;
// using System.Linq;                                                                   // использует расширение Linq
// using System.Text;
// using System.Collections.Generic;
// using System.Threading.Tasks;
// int[] myArray = { 13, 24, 12, 31, 34, 36, 14, 23, 15 };                    
// System.Console.WriteLine(myArray.Max());                                             // чтобы найти максимальное значение в 1 строчку
// System.Console.WriteLine(myArray.Where(i => i % 2 == 0).Sum());                      // нахождение суммы положительных чисел
// System.Console.WriteLine(myArray.Where(i => i % 2 != 0).Min());                      // нахождение минимального нечетного элемента
// int[] result = myArray.Distinct().ToArray();                                         // создание нового массива в котором только уникальные элементы первого
// int[] result = myArray.OrderBy(i => i).ToArray();                                    // сортировка по возрастанию
// int[] result = myArray.OrderByDescending(i => i).ToArray();                          // сортировка по убыванию
// Array.Sort(myArray);                                                                 // сортировка по возрастанию
// int result = Array.Find(myArray, i => i < 15);                                       // ищет элемент < 15 и присваивает первый на пути (с начала)
// int result = Array.FindLast(myArray, i => i < 15);                                   // ищет элемент < 15 и присваивает первый на пути (с конца)
// int[] result = Array.FindAll(myArray, i => i < 15);                                  // ищет элемент < 15 и формирует массив со всеми элементами < 15
// int result = Array.FindIndex(myArray, i => i == 15);                                 // ищет индекс элемента = 15 и присваивает первый на пути (с начала)
// int result = Array.FindIndexLast(myArray, i => i == 15);                             // ищет индекс элемента = 15 и присваивает первый на пути (с конца)
// Array.Reverse(myArray);                                                              // переписывает массив в обратном порядке(реверс)
// int[] result = myArray.Where(i => i < 15).ToArray();                                 // формирует массив удовлетворяющий условию где элементы < 15 (через Linq)
// int result = myArray.Where(i => i < 15).First();                                     // ищет первый элемент удовлетворяющий условию < 15 (через Linq)
// int result = myArray.Where(i => i < 15).FirstOrDefault();                            // ищет первый элемент удовлетворяющий условию < 15 (через Linq), если такого нет, то возвращ дефолтное
// System.Console.WriteLine(myArray[^1]);                                               // [^1] это означает последний номер индекса в массиве

// System.Console.WriteLine(myArray[^1]);

// for (int i = 0; i < myArray.Length; i++)
// {
//     System.Console.Write($"{myArray[i]} ");  
// }
// =====================================================================================================================================================================
void OutputMessage(string Message) //метод выдачи сообщений от метода (для консольного варианта исполнения)
{
    Console.WriteLine(Message);
}

int RandomMinMax(int minValue, int maxValue)
{
    return new Random().Next(minValue, maxValue);
}

int[] RandomArray(int elementCount, int minValue, int maxValue)
{
    int[] resultArray = new int[elementCount];
    for (int i = 0; i < elementCount; i++)
    {
        resultArray[i] = RandomMinMax(minValue, maxValue);
    }
    return resultArray;
}

int[] CreatingArray()
{
    OutputMessage($"Вводите исходные целые числа (от {int.MinValue} до {int.MaxValue}) по одному, когда введёте все числа напишите команду \"End\" или напишите \"Random\" для случайной генерации");
    int[] resultArray = new int[10];
    int i = 0;
    while (true) //запрашиваем числа по одному
    {
        string? UserString = string.Empty;
        UserString = Console.ReadLine();
        if (UserString.ToLower() == "end") break;

        if (UserString.ToLower() == "random")
        {
            int elementCount = RandomMinMax(5, 10);
            int minElementValue = RandomMinMax(-100, 0);
            int maxElementValue = RandomMinMax(0, 100);
            Array.Resize(ref resultArray, elementCount);
            resultArray = RandomArray(elementCount, minElementValue, maxElementValue);
            return resultArray;
        }

        if (int.TryParse(UserString, out int num))
        {
            resultArray[i] = num;
            i++;
            if (i == resultArray.Length) Array.Resize(ref resultArray, i + 10);
        }
        else
        {
            OutputMessage("Вы ввели не целое число или оно слишком большое");
        }
    }
    Array.Resize(ref resultArray, i);
    return resultArray;
}

int[] LeveOnlyEvenNumbersInArray(int[] numbersArray)
{
    int arrayLen = numbersArray.Length;
    int[] resultArray = new int[arrayLen];
    int j = 0;
    if (numbersArray != null || arrayLen != 0)
    {
        for (int i = 0; i < arrayLen; i++)
        {
            if (numbersArray[i] % 2 == 0)
            {
                resultArray[j] = numbersArray[i];
                j++;
            }
        }
    }
    Array.Resize(ref resultArray, j);
    return resultArray;
}

int[] numbersArray = CreatingArray();

//проверка результатов
OutputMessage(string.Join(',', numbersArray)); //отображаем исходный массив
OutputMessage(string.Join(',', LeveOnlyEvenNumbersInArray(numbersArray))); //отображаем получившийся массив


// Тестовые модули
RunTests();

void RunTests()
{
    Test1();
    Test2();
    Test3();
    Test4();
}

void Test1()
{
    int[] numArray = new int[] { 1, 2, 3, 4 };
    int[] expectedArray = new int[] { 2, 4 };
    int[] resultArray = LeveOnlyEvenNumbersInArray(numArray);

    for (int i = 0; i < expectedArray.Length; i++)
    {
        if (expectedArray[i] != resultArray[i])
        {
            OutputMessage("not passed Test1");
            return;
        }
    }
    OutputMessage("passed Test1");
}

void Test2()
{
    int[] numArray = new int[] { 1, 3, 4, 5, 7, 1, 3 };
    int[] expectedArray = new int[] { 4 };
    int[] resultArray = LeveOnlyEvenNumbersInArray(numArray);

    for (int i = 0; i < expectedArray.Length; i++)
    {
        if (expectedArray[i] != resultArray[i])
        {
            OutputMessage("not passed Test2");
            return;
        }
    }
    OutputMessage("passed Test2");
}

void Test3()
{
    int[] numArray = new int[] { 2, -4, 6 };
    int[] expectedArray = new int[] { 2, -4, 6 };
    int[] resultArray = LeveOnlyEvenNumbersInArray(numArray);

    for (int i = 0; i < expectedArray.Length; i++)
    {
        if (expectedArray[i] != resultArray[i])
        {
            OutputMessage("not passed Test3");
            return;
        }
    }
    OutputMessage("passed Test3");
}

void Test4()
{
    int[] numArray = new int[] { 1, 3, 7 };
    int[] expectedArray = new int[] { };
    int[] resultArray = LeveOnlyEvenNumbersInArray(numArray);

    for (int i = 0; i < expectedArray.Length; i++)
    {
        if (expectedArray[i] != resultArray[i])
        {
            OutputMessage("not passed Test4");
            return;
        }
    }
    OutputMessage("passed Test4");
}
// Это все контрольное задание Александра Сиб, было бы не плохо поинтересоваться у него как он это делал

// =====================================================================================================================================================================

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
int[,] myArray = new int[,]
{
    {2,45,12,51,52},
    {6,7,8,3,1},
    {1,5,65,78,13},
    {6,3,151,5,65}
};
for (int i = 0; i < myArray.GetLength(0); i++)            // Задали двумерный массив, хатем перебирая его вывели на экран в виде "таблички"
{
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        System.Console.Write(myArray[i, j] + "\t");
    }
    System.Console.WriteLine();
}
