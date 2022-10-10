/*
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
int TwoNumber(int num)
{
    int result;

    int dec = num / 10;
    int ed = num / 100;

    result = dec - ed * 10;

    return result;
}

int number = new Random().Next(100, 1000);
int twoNumber = TwoNumber(number);

Console.WriteLine($"The biggest digit of {number} is {twoNumber}");
*/

/*
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
int ThirdDigit(int num)
{
    int result;

    if(num <= 99)
    result = -1;
    else
    {
        while (num > 999)
        num = num / 10;
        result = num % 10;
    }
    return result;
}

int number = new Random().Next(1, 1000);

int res = ThirdDigit(number);
if (res > -1)
    Console.WriteLine($"The biggest digit of {number} is {res}");
else
    Console.WriteLine($"No third digit.");
*/


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
bool SevenDays(int day)
{
    bool result;

    if (day == 6 ^ day == 7)
        result = true;
    else
        result = false;
    return result;
}
Console.WriteLine("Input a number day of the week: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

bool numDayWeek =  SevenDays(dayNumber);

if (numDayWeek)
    Console.WriteLine($"Yes, the {dayNumber} day of the week is a weekend!");
else
    Console.WriteLine($"No, the {dayNumber} day of the week is not a weekend!");