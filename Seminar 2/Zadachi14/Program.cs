        // ========================== Задача 0 ===========================
        // int Method1(int a)
        // {
        //     int proizv = a * a;
        //     return proizv;
        // }
        // int A = Method1(5);
        // Console.WriteLine($"Квадрат введенного числа равен: {A}");

        // ========================== Задача 1 ===========================
        // По двум заданным числам проверять является ли первое квадратом второго
        // bool FirstSquerOrNo(int a, int b)
        // {

        // if ( b * b == a) 
        //         {
        //         return true;
        //         }
        //         else 
        //         {
        //         return false;
        //         }
        // }
        // Console.WriteLine(FirstSquerOrNo(8, 3));


        // ========================== Задача 2 ===========================

        // Вывести большее число из 2-х
        // int WhoMore(int a, int b)
        // {
        // return a > b? a : b;
        // }

        // Console.WriteLine(WhoMore(2, 177));



        // ========================== Задача 3 ===========================
        //По заданному номеру дня недели вывести его название


             // понедельник вторник среда четверг пятница суббота воскресенье
string weekDays(int day)
{
        if(day <= 0 || day >= 8) return "Вы с другой планеты";
        string[] weekDays = new string[] {  "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" , "Sun"}; 
        
        return weekDays[day-1];  // Спасибо Сергею за спасенные ячейки памяти!
//         int length = weekDays.Length;
//         string result = String.Empty;
//         for (int i = 0; i < length; i++)
//         {
//                 if( day > 7)
//                 {
//                 Console.WriteLine("Такого дня недели не существует");
//                 break;
//                 }
//                 else
//                 {
//                 if (day - 1 == i)
//                 result = result + weekDays[i];  
//                 }           
//         }
//                 return result;  
} 
Console.WriteLine(weekDays(0));     



        // ========================== Задача 4 ===========================
        
        // Найти максимальное из трех чисел 
        // int MaxOfThree(int a, int b, int c)
        // {
        //         int max = a;
        //         if(b > a) max = b;
        //         if(c > b)
        //         {
        //                 if(c > a) max = c;
        //         }
        //         return max;
        // }

        // Console.WriteLine($"Максимальное число = {MaxOfThree(122, 12, 33)}");
        
        
        
        // ========================== Задача 5 ===========================

        // Написать программу вычисления значения функции sin^10(a)
        // в скобках угол в градусах

        // double UseCombinedSineCosine(double degrees)
        // {
        //         double angle = Math.PI * degrees / 180.0;
        //         double sinAngle = Math.Sin(angle);
        //         double result = sinAngle * sinAngle * sinAngle * sinAngle * sinAngle * sinAngle * sinAngle * sinAngle * sinAngle * sinAngle;

        // return result;
        // }

        // Console.WriteLine(UseCombinedSineCosine(30));



        // ========================== Задача 6 ===========================
        
        // Выяснить является ли число чётным

        // посмотреть в записи...

        // ========================== Задача 6 ===========================

