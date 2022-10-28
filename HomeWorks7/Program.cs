﻿/*
//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.    0,5 7 -2 -0,2    1 -3,3 8 -9,9     8 7,8 -7,1 
double[,] CreateRandomDouble2Array()
{
 Console.Write("Input a number of rows: ");
 int rows = Convert.ToInt32(Console.ReadLine());
 Console.Write("Input a number of columns: ");
 int columns = Convert.ToInt32(Console.ReadLine());
 Console.Write("Input a min possible value: ");
 int minValue = Convert.ToInt32(Console.ReadLine());
 Console.Write("Input a max possible value: ");
 int maxValue = Convert.ToInt32(Console.ReadLine());
 double[,] array = new double[rows, columns];
 Random rand = new Random();
 for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = Math.Round((rand.Next(minValue, maxValue) + rand.NextDouble()), 1);
    return array;
}
void Print2DoubleArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "  ");
        Console.WriteLine();
    }
}
double[,] myArray = CreateRandomDouble2Array();
Print2DoubleArray(myArray);
*/

/*
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> числа с такими индексами в массиве нет
int[,] CreateRandom2Array()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Print2Array(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

void FindElement(int[,] array)
{
    Console.Write("Input an index 'i' of element: ");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input an index 'j' of element: ");
    int j = Convert.ToInt32(Console.ReadLine());
    if ((i >= 0 && i < array.GetLength(0)) && (j >= 0 && j < array.GetLength(1)))
        Console.WriteLine($"Element with indexes [{i},{j}] = {array[i, j]}");
    else
        Console.WriteLine("There is no element with such indexes.");
}

int[,] myArray = CreateRandom2Array();
Print2Array(myArray);
FindElement(myArray);
*/


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int[,] CreateRandom2Array()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Print2Array(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

int[,] myArray = CreateRandom2Array();
Print2Array(myArray);

double[] FindColumnsElementsAverage(int[,] array)
{

    double[] newarray = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
            sum = sum + array[i, j];
        newarray[j] = Math.Round((sum / array.GetLength(0)),1);
    }  
    return newarray;
}

void PrintArray(double[] array)
{
    Console.Write("New Average array: { ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("}.");
}

double[] newarray = FindColumnsElementsAverage(myArray);
PrintArray(newarray);