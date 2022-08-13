void Zadacha41 ()
{
    //Задача 41: Пользователь вводит с клавиатуры M чисел. 
    //Посчитайте, сколько чисел больше 0 ввёл пользователь.
    Console.WriteLine ("Введите количество вводимых чисел ряда:");
    int numbers = Convert.ToInt32 (Console.ReadLine ());
    int [] arrayNumbers = new int [numbers];
    int countPositive = 0;
    Console.WriteLine ("Заполните ряд чисел:");
    for (int i = 0; i < numbers; i++)
    {
        Console.Write ($"Число {i+1} = ");
        arrayNumbers [i] = Convert.ToInt32 (Console.ReadLine ());
        if (arrayNumbers [i] > 0) countPositive++; 
    } 
    Console.WriteLine ($"Количество введённых чисел больше 0: {countPositive}");
}

void Zadacha43 ()
{
    //Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
    //заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем. 
    // пример: b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
    Console.WriteLine ("Для вычисления координат (x, y) пересечения двух прямых воспользуеся формулой");
    Console.WriteLine ("y = k(i)*x + b(i), где");
    Console.WriteLine ("k(i)");
    Console.WriteLine ("b(i)");
    Console.Write ("Введите значение k1 первой прямой - ");
    double k1 = Convert.ToInt32 (Console.ReadLine ());
    Console.Write ("Введите значение b1 первой прямой - ");
    double b1 = Convert.ToInt32 (Console.ReadLine ());
    Console.Write ("Введите значение k2 первой прямой - ");
    double k2 = Convert.ToInt32 (Console.ReadLine ());
    Console.Write ("Введите значение b2 первой прямой - ");
    double b2 = Convert.ToInt32 (Console.ReadLine ());
    double x;
    double y;
    if (k1 == k2) Console.WriteLine ("Прямые - параллельны");
    else Console.WriteLine ($"Координаты пересечения двух прямых - ({x = (b2 - b1)/(k1 - k2)}, {y = k1 * x + b1})");
}

//Zadacha41 ();
Zadacha43 ();