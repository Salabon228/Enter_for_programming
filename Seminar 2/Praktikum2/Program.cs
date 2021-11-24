// Консольная игра "Угадай число"
// Комп загадал число в некотором диапазоне, например от 1 до 100. 
// Далее он предлагает игроку угадать это число. Игрок вводит некоторое число и комп "отвечает":

// правильное ли это число или
// Загаданное число больше чем введенное
// загаданное число меньше чем введенное. 
// После этого игрок делает следующую догадку. 
// У Игрока есть некоторое количество попыток.
// Если игрок потратил все свои попытки, то игра заканчивается. 
// Если игрок угадал число, но попытки еще остались, игра также заканчивается.


// 1. Определить условия (какой диапазон для загадывания чисел - мы его задаем, 
// формируем ррандомно или запрашиваем у пользователя?; определиться
// с количеством попыток, либо запросить у участника)
// 2. Загадать число в указанном диапазоне.
// 3. Начало игры - описываем правила.
// 4. Запрашиваем у пользователя число. Пользователь вводит некоторое число 
// (добавить проверку нештатных ситуаций). Определяем как оно соотносится 
// с нашим загаданным и жаем следующие инструкции игроку.
// Если пользователь не угадал, то у него сгорает 1 попытка.
// 5. Игра продолжается пока есть попытки или пока пользователь не угадал число.


// int requestNumber() - метод запросит у игрока число,
// сделает все необходимые преобразования и вернет нам это число.


// int createNumber(int leftBound, int rightBound) - загадает число в указанном диапазоне
// и вернет его нам.


// bool MakeMove( int SecretNumber, int CountOfAttempts ) - метод в котором
// запрограммирован один игровой ход, в результате метод возвращает либо 
// true либо false.  


// int SecretNumber = createNumber(1, 100);
// int PlayersNumber = requestNumber();


int createNumber(int MinValue, int MaxValue) // загадали число
{
    int number = new Random().Next(MinValue, MaxValue);
    return number;
}

int compnumber = createNumber( 1, 101 );
System.Console.WriteLine(compnumber);


//=====================================================
System.Console.WriteLine("Введите кол-во попыток:");
int count = Convert.ToInt32(Console.ReadLine());   // количество попыток


//=====================================================
int RequestNumber() // проверяем число
{
    // bool result = false; // надо подумать
    // while (result != true)
    //{
    System.Console.Write("Введите число:    ");
    string writeNumber = Console.ReadLine();
    bool result = int.TryParse(writeNumber, out int number);
    
    
    System.Console.WriteLine();
    if (result == false) System.Console.WriteLine("Число введено неверно.");

    else
    {
        if (number < 0 || number > 101)
        {
            System.Console.WriteLine("Введите число в пределах диапазона");
        }
        else System.Console.WriteLine(number);
    }
    return number;
}

//=====================================================

void MakeMove(int count,int compnumber)
{
    int usernumber = 0;
    for (int i = 0; i < count; i++)
    {
        usernumber = RequestNumber();
        if (usernumber == compnumber)
        {
            System.Console.WriteLine("Ура, вы угадали число!");
            break;
        } 
        if (usernumber < compnumber) System.Console.WriteLine("Введеное число меньше загадоного ");
        if (usernumber > compnumber) System.Console.WriteLine("Введеное число больше загадоного");
    }
    System.Console.WriteLine("Игра закончена");
}

MakeMove(count, compnumber);
