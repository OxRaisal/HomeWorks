
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2     1, -7, 567, 89, 223-> 3
int AmountPositiveNums(int amountNum)
{
 int count = 0; 
 for(int i = 1; i <= amountNum; i++)
    {
 Console.Write("Введите число: ");
 double num = Convert.ToDouble(Console.ReadLine());
 if(num>0) count++;
    }
 return count;
}

Console.Write("Введите желаемое количество чисел: ");
int amountNum = Convert.ToInt32(Console.ReadLine());
int result = AmountPositiveNums(amountNum);
Console.WriteLine($"Количество положительных чисел = {result}");



/*
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
void IntersectionPoint(double b1, double k1, double b2, double k2)
{
    if (k1 == k2) Console.WriteLine("Прямые паралельны, точка пересечения отсутствует.");
    else
    {
        double x = (b1 - b2) / (k2 - k1);
        double y = Math.Round(k2 * x + b2, 2);
        Console.WriteLine($"Координаты точки пересечения прямых: x: {x}, y: {y}.");
    }
}
IntersectionPoint(2, 9, 4, 5);
*/