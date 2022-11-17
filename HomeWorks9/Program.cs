/*
//Задача 1. Задайте значение N. Напишите программу, которая выведет все 
//натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"           N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void PrintDigits(int n)
{
    Console.Write(n + " ");
    if (n >1) PrintDigits(n - 1);
}

int n = 7;
Console.Write($"N = {n} -> ");
PrintDigits(n);
*/

/*
// Задача 2. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120       M = 4; N = 8. -> 30
int SumElements(int firstNum, int lastNum)
{
    if (firstNum > lastNum) return firstNum + SumElements(firstNum-1, lastNum);
    if (firstNum < lastNum) return firstNum + SumElements(firstNum + 1, lastNum);
    else return firstNum;
}

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = SumElements(m,n);
Console.WriteLine("Сумма натуральных элементов в промежутке от m до n: " + result);
*/


// Задача 3. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9       m = 3, n = 2 -> A(m,n) = 29

int A(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return A(m - 1, 1);
    if (m > 0 && n > 0) return A(m - 1, A(m,n - 1));
    return A(m,n); 
}                  

Console.Write("Введите число m больше 0: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число n больше 0: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {A(m,n)}");