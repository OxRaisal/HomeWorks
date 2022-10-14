
//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
bool PalindromeNum(int number)
{
    bool result = true;

    while(number > 9)
    {
        int lastDigit = number % 10;
        int firstDigit = number;
        int countDigit = 0;

        while (firstDigit >= 10)
        {
            countDigit++;
            firstDigit /= 10;
        }
        if (lastDigit != firstDigit)
        {
            result = false;
            break;
        }

        number = number / 10 % (Convert.ToInt32(Math.Pow(10, countDigit - 1)));
    }
    return result;
}

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool palindrome = PalindromeNum(number);

if(palindrome)
    Console.WriteLine($"Число {number} Является палиндромом.");
else
    Console.WriteLine($"Число {number} Не является палиндромом.");

/*
//Задача 21. Напишите программу, которая принимает на вход 
//координаты двух точек и находит расстояние между ними в 3D пространстве.
double Distance(double xa, double xb, double ya, double yb, double za, double zb)
{
    return Math.Sqrt(Math.Pow((xb - xa),2) + Math.Pow((yb-ya),2) + Math.Pow((zb-za),2));
}

Console.WriteLine("Input xa-coordinate: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input ya-coordinate: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input xb-coordinate: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input yb-coordinate: ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input za-coordinate: ");
double za = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input zb-coordinate: ");
double zb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Distance(xa, xb, ya, yb, za, zb));
*/

/*
//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void WriteQ(int n)
{
    int count = 1;
    while(count <= n)
    {
        Console.WriteLine(Math.Pow(count,3));
        count++;
    }
}
Console.WriteLine("Input n number");
int n = Convert.ToInt32(Console.ReadLine());
WriteQ(n);
*/