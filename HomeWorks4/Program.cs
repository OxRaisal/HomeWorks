/*
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит
// число A в натуральную степень B.     3, 5 -> 243 (3⁵)       2, 4 -> 16

double PowNumbers(int a, int b)
{
    double Pow  = 1;
    
    Pow = Math.Pow(a, b);

    return Pow;
}

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b number: ");
int b = Convert.ToInt32(Console.ReadLine());

double pow = PowNumbers(a, b);
Console.WriteLine($"{pow} ({a}^{b})");
*/

/*
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11      82 -> 10      9012 -> 12
int SumNumberDigit(int num)
{
    int sum = 0;
    
    if(num < 0)
        num *= -1;

    while(num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

Console.Write("Введите число: ");
int sumNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цифр числа {sumNum} будет равна {SumNumberDigit(sumNum)}");
*/

/*
// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
// m = 5 -> [1, 2, 5, 7, 19]       m = 3 -> [6, 1, 33]
int[] RandomMassiv(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(minValue, maxValue +1);
    
    return array;
}
void ShowArray(int[] array)
{
    for(int i =0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int min = 0;
int max = 100;

int[] myArray = RandomMassiv(size, min, max);
// Console.WriteLine($"m = {size} -> {arrayF(myArray)}");
Console.ForegroundColor = ConsoleColor.Green;
ShowArray(RandomMassiv);
Console.ReadLine();
*/
int [] numbers = new int[7];
Console.Write("[");

for (int i = 0; i < numbers.Length; i++)
 {
 numbers [i] = new Random().Next(0, 100);
 Console.Write(" " + Method (i) + " ");
 }
Console.Write("]");

int Method (int a)
{
 return numbers[a];
}