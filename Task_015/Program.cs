// Задача 15: Напишите программу, которая 
// 1. принимает на вход цифру, обозначающую день недели, и 
// 2. проверяет, является ли этот день выходным.
// дополнительно - проверка если равно 0 или больше 7
// 6 -> да
// 7 -> да
// 1 -> нет

// Первый способ - без обявления метода

// Console.Write("Введите день недели: ");
// int dayOfWeek = Convert.ToInt32(Console.ReadLine());
// if (dayOfWeek == 6 || dayOfWeek == 7) Console.WriteLine($"{dayOfWeek} -> да");
// else if (dayOfWeek > 0 && dayOfWeek <6) Console.WriteLine($"{dayOfWeek} -> нет");
// else Console.WriteLine("Нет такого дня недели");

// Второй способ. Объявление метода

int DayOfWeek(int num)
{
    if (num == 6 || num == 7) return 1;
    else if (num > 0 && num <6) return 2;
    else return 3;
}

Console.Write("Введите день недели: ");
int a = Convert.ToInt32(Console.ReadLine());

if (DayOfWeek(a) == 1) Console.WriteLine($"{a} -> да");
else if (DayOfWeek(a) == 2) Console.WriteLine($"{a} -> нет");
else Console.WriteLine("Нет такого дня недели");