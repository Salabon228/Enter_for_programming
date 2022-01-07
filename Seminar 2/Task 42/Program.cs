// ========================== Задача 42 ===========================

// 42. Определить сколько чисел больше 0 введено с клавиатуры
int count = 0;
System.Console.WriteLine("для выхода напишите exit и нажмите Enter");
System.Console.WriteLine("введите число: ");
for (int i = 0; i < 1000; i++)
{
    string? msg = Console.ReadLine();
    try
    {
        if (msg == "exit")
        {
            break;
        }
        else
        {
            int num = Convert.ToInt32(msg);
            if (num > 0)
            {
                count++;
            }
        }
    }
    catch (System.Exception)
    {
        System.Console.WriteLine("Вы ввели не число!");
    }
}
if (count == 0) Console.WriteLine($"Вы не ввели ни одного положительного числа");
if (count == 1) Console.WriteLine($"Вы ввели одно положительное число");
if (count > 1 && count < 5) Console.WriteLine($"Вы ввели {count} положительных числа");
if (count > 4) Console.WriteLine($"Вы ввели {count} положительных чисел");